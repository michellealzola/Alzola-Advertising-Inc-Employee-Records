using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Class
{
    public partial class MainForm : Form
    {
        private List<Employee> employees = new List<Employee>();
        private string name;
        private string id;
        private string department;
        private string position;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            name = tBoxInputName.Text;
            id = tBoxInputIdNumber.Text;
            department = tBoxInputDepartment.Text;
            position = tBoxInputPosition.Text;

            if (name != null && id != null && department != null && position != null)
            {
                Employee employee = new Employee(name, id, department, position);
                employees.Add(employee);
            }
            else if (name != null && id != null && department == null && position == null)
            {
                Employee employee = new Employee(name, id);
                employees.Add (employee);
            }
            else
            {
                Employee employee = new Employee();
                employees.Add(employee);
            }

            for(int i = 0; i < employees.Count; i++)
            {
                lBoxEmployeeRecord.Items.Add(employees[i].Name.ToString());
            }
        }

        private void lBoxEmployeeRecord_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
