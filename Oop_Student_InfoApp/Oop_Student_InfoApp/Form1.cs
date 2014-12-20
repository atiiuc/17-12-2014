using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oop_Student_InfoApp
{
    public partial class Form1 : Form
    {Student info=new Student();
        public Form1()
        {
            InitializeComponent();
        }

        public void TextFieldClear()
        {
            regText.Text = String.Empty;
            firstText.Text = String.Empty;
            lastText.Text = String.Empty;

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            info.reg = regText.Text;
            info.firstname = firstText.Text;
            info.lastname = lastText.Text;
           String fullname= info.getFullname(info.firstname,info.lastname);
            MessageBox.Show(fullname + ", your reg no:" + info.reg);
            TextFieldClear();
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            regText.Text = info.reg;
            firstText.Text = info.firstname;
            lastText.Text = info.lastname;
        } 
    }
}
