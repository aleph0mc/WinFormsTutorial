using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using System.IO;
using System.Xml.Schema;

namespace WinFormsXmlDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXmlStatic_Click(object sender, EventArgs e)
        {
            var xmlDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("Creating XML Tree using LINQ to XML"),
                    new XElement("Students",
                        new XElement("Student",
                            new XAttribute("Id", 101),
                            new XElement("Name", "Andrew"),
                            new XElement("Gender", "Male"),
                            new XElement("TotalMarks", 800)
                        ),
                        new XElement("Student",
                            new XAttribute("Id", 102),
                            new XElement("Name", "Moira"),
                            new XElement("Gender", "Female"),
                            new XElement("TotalMarks", 900)
                        ),
                        new XElement("Student",
                            new XAttribute("Id", 103),
                            new XElement("Name", "Pam"),
                            new XElement("Gender", "Female"),
                            new XElement("TotalMarks", 850)
                        ),
                        new XElement("Student",
                            new XAttribute("Id", 104),
                            new XElement("Name", "Milko"),
                            new XElement("Gender", "Male"),
                            new XElement("TotalMarks", 950)
                        )
                    )
                );

            xmlDoc.Save(@"data.xml");
        }

        private void btnDynXml_Click(object sender, EventArgs e)
        {
            var xmlDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("Creating XML Tree using LINQ to XML"),
                    new XElement("Students",
                        from student in Student.GetAllStudents()
                        select new XElement("Student",
                            new XAttribute("Id", student.Id),
                            new XElement("Name", student.Name),
                            new XElement("Gender", student.Gender),
                            new XElement("TotalMarks", student.TotalMarks)

                        )
                )
            );

            xmlDoc.Save(@"data_in_mem.xml");

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();

            //var names = from student in XDocument.Load("data.xml")
            //            .Descendants("Student")
            //            where (int)student.Element("TotalMarks") > 800
            //            orderby (int)student.Element("TotalMarks") descending
            //            select student.Element("Name").Value;
            // another way to write the query is
            var names = from student in XDocument.Load("data.xml")
                        .Element("Students").Elements("Student")
                        where (int)student.Element("TotalMarks") > 800
                        orderby (int)student.Element("TotalMarks") descending
                        select student.Element("Name").Value;


            foreach (var name in names)
                lstStudents.Items.Add(name);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtId.Text);
            var name = txtName.Text;
            var gender = rdbMale.Checked ? "Male" : "Female";
            var totMarks = int.Parse(txtTotMarks.Text);

            var xmlDoc = XDocument.Load("data.xml");

            // check if id already exists
            var idExists = xmlDoc.Element("Students").Elements("Student")
                .Where(el => el.Attribute("Id").Value == id.ToString()).Any();

            if (idExists)
            {
                MessageBox.Show("Id already assigned.\n\rPlease choose another Id.", "Wrong Id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // add the element as last
            xmlDoc.Element("Students").Add(
                new XElement("Student",
                    new XAttribute("Id", id),
                    new XElement("Name", name),
                    new XElement("Gender", gender),
                    new XElement("TotalMarks", totMarks)
                )
            );

            // add the element as first
            //xmlDoc.Element("Students").Add(
            //    new XElement("Student",
            //        new XAttribute("Id", id),
            //        new XElement("Name", name),
            //        new XElement("Gender", gender),
            //        new XElement("TotalMarks", totMarks)
            //    )
            //);

            // add the element before position Id = 103
            //xmlDoc.Element("Students")
            //    .Elements("Student")
            //    .Where(el => el.Attribute("Id").Value == "103")
            //    .FirstOrDefault()
            //    .AddBeforeSelf(
            //        new XElement("Student",
            //            new XAttribute("Id", id),
            //            new XElement("Name", name),
            //            new XElement("Gender", gender),
            //            new XElement("TotalMarks", totMarks)
            //        )
            //);

            // add the element after position Id = 103
            //xmlDoc.Element("Students")
            //    .Elements("Student")
            //    .Where(el => el.Attribute("Id").Value == "103")
            //    .FirstOrDefault()
            //    .AddAfterSelf(
            //        new XElement("Student",
            //            new XAttribute("Id", id),
            //            new XElement("Name", name),
            //            new XElement("Gender", gender),
            //            new XElement("TotalMarks", totMarks)
            //        )
            //);


            xmlDoc.Nodes().OfType<XComment>().FirstOrDefault().Value = $"XML Added Id: {id.ToString()} at {DateTime.Now.ToString("yyyy/MM/dd HH:mm")}";

            // with formatting
            xmlDoc.Save(@"data.xml", SaveOptions.None);

            // update combo
            Form1_Load(this, EventArgs.Empty);

            MessageBox.Show("Operation completed successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var xmlDoc = XDocument.Load("data.xml");

            var arrSt = xmlDoc.Element("Students")
                .Descendants("Student")
                .Select(s => new Student { Id = int.Parse(s.Attribute("Id").Value), Name = s.Element("Name").Value })
                .ToArray();

            cmbStIds.DisplayMember = "Name";
            cmbStIds.ValueMember = "Id";

            cmbStIds.Items.Clear();

            cmbStIds.Items.AddRange(arrSt);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selStudent = cmbStIds.SelectedItem as Student;
            var selStId = selStudent.Id;

            //MessageBox.Show($"Selected Id: {selStId.ToString()}");

            var totMarks = int.Parse(txtUpdtTotMarks.Text);

            var xmlDoc = XDocument.Load("data.xml");
            xmlDoc.Element("Students")
                .Elements("Student")
                .Where(el => el.Attribute("Id").Value == selStId.ToString())
                .FirstOrDefault()
                .SetElementValue("TotalMarks", totMarks);

            // OR
            //xmlDoc.Element("Students")
            //    .Elements("Student")
            //    .SingleOrDefault(el => el.Attribute("Id").Value == selStId.ToString())
            //    .Element("TotalMarks").SetValue(totMarks);

            xmlDoc.Nodes().OfType<XComment>().FirstOrDefault().Value = $"XML Updated Id: {selStId.ToString()} at {DateTime.Now.ToString("yyyy/MM/dd HH:mm")}";

            xmlDoc.Save(@"data.xml");

            // update combo
            Form1_Load(this, EventArgs.Empty);

            MessageBox.Show("Operation completed successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selStudent = cmbStIds.SelectedItem as Student;
            var selStId = selStudent.Id;

            var xmlDoc = XDocument.Load("data.xml");

            xmlDoc.Root.Elements().Where(el => el.Attribute("Id").Value == selStId.ToString()).FirstOrDefault().Remove();

            xmlDoc.Nodes().OfType<XComment>().FirstOrDefault().Value = $"XML Deleted Id: {selStId.ToString()} at {DateTime.Now.ToString("yyyy/MM/dd HH:mm")}";

            xmlDoc.Save(@"data.xml");

            // update combo
            Form1_Load(this, EventArgs.Empty);

            MessageBox.Show("Operation completed successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbStIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selStudent = cmbStIds.SelectedItem as Student;
            var selStId = selStudent.Id;

            var xmlDoc = XDocument.Load("data.xml");

            var totMarks = xmlDoc.Element("Students").Elements("Student")
                .SingleOrDefault(el => el.Attribute("Id").Value == selStId.ToString())
                ?.Element("TotalMarks").Value;

            txtUpdtTotMarks.Text = totMarks;

        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            var xmlDoc = XDocument.Load("data.xml");
            xmlDoc.Descendants("Student").ToList()
                .ForEach(
                    el =>
                    {
                        sb.AppendFormat("{0}, ", el.Attribute("Id").Value);
                        sb.AppendFormat("{0}, ", el.Element("Name").Value);
                        sb.AppendFormat("{0}, ", el.Element("Gender").Value);
                        sb.AppendFormat("{0}", el.Element("TotalMarks").Value);
                        sb.AppendLine();
                    }
                );

            using (var sw = new StreamWriter("export.csv"))
                sw.Write(sb.ToString());

            MessageBox.Show("Operation completed successfully", "Csv Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportHtml_Click(object sender, EventArgs e)
        {
            var xDocExport = new XDocument(
                new XElement("table", new XAttribute("border", 1),
                    new XElement("thead",
                        new XElement("tr",
                            new XElement("th", "Id"),
                            new XElement("th", "Name"),
                            new XElement("th", "Gender"),
                            new XElement("th", "TotalMarks")
                        )
                    ),
                    new XElement("tboby",
                        XDocument.Load("data.xml").Descendants("Student")
                            .Select(el =>
                                new XElement("tr",
                                    new XElement("td", el.Attribute("Id").Value),
                                    new XElement("td", el.Element("Name").Value),
                                    new XElement("td", el.Element("Gender").Value),
                                    new XElement("td", el.Element("TotalMarks").Value)
                                )
                            )
                    )
                )
            );

            xDocExport.Save(@"data.html");

            MessageBox.Show("Operation completed successfully", "HTML Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnValidateXml_Click(object sender, EventArgs e)
        {
            var schema = new XmlSchemaSet();
            schema.Add("", "student.xsd");

            var xmlDoc = XDocument.Load("data.xml");

            var validationErrors = false;

            xmlDoc.Validate(schema,
                (s, ve) =>
                {
                    MessageBox.Show(ve.Message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationErrors = true;
                }    
            );

            if (validationErrors)
                MessageBox.Show("Validation failed");
            else
                MessageBox.Show("Validation succeeded");

        }
    }
}
