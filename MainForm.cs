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
            lBoxEmployeeRecord.Items.Clear();

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

            tBoxInputName.Text = "";
            tBoxInputIdNumber.Text = "";
            tBoxInputDepartment.Text = "";
            tBoxInputPosition.Text = "";

            tBoxInputName.Focus();
        }

        private void lBoxEmployeeRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lBoxEmployeeRecord.SelectedIndex;

            if (index != -1)
            {
                name = employees[index].Name.ToString();
                id = employees[index].IdNumber.ToString();
                department = employees[index].Department.ToString();    
                position = employees[index].Position.ToString();
            }

            EmployeeRecordForm employeeRecordForm = new EmployeeRecordForm();

            employeeRecordForm.lBoxEmployeeInfo.Items.Add("Name: " + name);
            employeeRecordForm.lBoxEmployeeInfo.Items.Add ("ID Number: " + id);
            employeeRecordForm.lBoxEmployeeInfo.Items.Add("Department: " + department);
            employeeRecordForm.lBoxEmployeeInfo.Items.Add("Position: " + position);

            employeeRecordForm.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tBoxInputName.Text = "";
            tBoxInputIdNumber.Text = "";
            tBoxInputDepartment.Text = "";
            tBoxInputPosition.Text = "";

            tBoxInputName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
