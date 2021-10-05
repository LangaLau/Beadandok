using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {

        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();

            label1_last.Text = Resource1.FullName;
            
            button1.Text = Resource1.Addbtn;

            listBox1_fullname.DataSource = users;
            listBox1_fullname.ValueMember = "ID";
            listBox1_fullname.DisplayMember = "FullName";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = textBox1_lastname.Text           
            };
            users.Add(u);
        }
    }
}
