using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTreeViewAndListView
{
    public partial class Form1 : Form
    {
        private List<Department> _lstDepts;
        private List<Employee> _lstEmps;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _lstDepts = DataGenerator.GetDepartments();
            _lstEmps = DataGenerator.GetEmployees();
            foreach (var dept in _lstDepts)
            {
                var tn = new TreeNode($"ID = {dept.DeptId.ToString()}");
                tn.Tag = dept.DeptId;

                switch (dept.Location)
                {
                    case "L1":
                        tn.ImageIndex = 0;
                        break;
                    default:
                        tn.ImageIndex = 1;
                        break;
                }
                tvCompDept.Nodes[0].Nodes.Add(tn);
                tn.Nodes.Add(dept.DeptId.ToString(), dept.DeptName, -1);
                tn.Nodes.Add(dept.DeptId.ToString(), dept.Location, -1);
            }
        }

        private void cmnsLargeIcons_Click(object sender, EventArgs e)
        {
            lvCompEmp.View = View.LargeIcon;
        }

        private void cmnsSmallIcons_Click(object sender, EventArgs e)
        {
            lvCompEmp.View = View.SmallIcon;
        }

        private void cmnsList_Click(object sender, EventArgs e)
        {
            lvCompEmp.View = View.List;
        }

        private void cmnsDetails_Click(object sender, EventArgs e)
        {
            lvCompEmp.View = View.Details;
        }

        private void tvCompDept_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show($"Level: {e.Node.Level.ToString()}");
            if (1 == e.Node.Level)
            {
                lvCompEmp.Items.Clear();
                var deptId = (int)e.Node.Tag;
                var arrlstEmpsInDept = _lstEmps.Where(d => deptId == d.Deptid)
                    .Select(emp => // inline function
                    {
                        var lvItem = new ListViewItem(emp.EmpId.ToString());
                        lvItem.ImageIndex = 1;
                        lvItem.SubItems.Add(emp.EmpName);
                        var deptName = _lstDepts.Single(d => emp.Deptid == d.DeptId)?.DeptName;
                        lvItem.SubItems.Add(deptName);

                        return lvItem;
                    }).ToArray();
                lvCompEmp.Items.AddRange(arrlstEmpsInDept);
            }
        }
    }
}
