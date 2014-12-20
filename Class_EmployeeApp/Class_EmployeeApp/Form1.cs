using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_EmployeeApp
{
    public partial class Form1 : Form
    {EmployeeInfo employee1=new EmployeeInfo();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            employee1.id = Convert.ToInt32(idText.Text);
            
            employee1.name = nameText.Text;
            employee1.salary = Convert.ToInt32(salaryText.Text);
            MessageBox.Show(employee1.id+"\n"+employee1.name+"\n"+employee1.salary);
            idText.Text = String.Empty;
            nameText.Text = String.Empty;
            salaryText.Text = String.Empty;
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            idText.Text = Convert.ToString(employee1.id);
            nameText.Text = employee1.name;
            salaryText.Text = Convert.ToString(employee1.salary);
        }
    }
}
