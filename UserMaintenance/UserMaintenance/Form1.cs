using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            button2_SaveFile.Text = Resource1.WroteToFile;
            button3_Delete.Text = Resource1.Delete;

            listBox1_fullname.DataSource = users;
            listBox1_fullname.ValueMember = "ID";
            listBox1_fullname.DisplayMember = "FullName";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User()
            { FullName = textBox1_lastname.Text };
            users.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {//csv írás
            var sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK)
                return;
            //mentés helye
            using (var sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                foreach (var u in users)
                    sw.WriteLine(string.Format(
                        "{0};{1}",      //fajl nevének kiírása
                        u.ID,
                        u.FullName));
        }

        private void button3_Delete_Click(object sender, EventArgs e)
        {
            var töröl = listBox1_fullname.SelectedItem;
            if (töröl != null)
                users.Remove((User)töröl);
        }
    }
}
