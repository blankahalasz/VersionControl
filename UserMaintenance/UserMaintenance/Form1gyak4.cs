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
    public partial class Form1gyak4 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1gyak4()
        {
            InitializeComponent();
            lblLastName.Text = Resource.FullName;
          
            btnAdd.Text = Resource.Add;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";

            var u = new User()
            {
                FullName = txtLastName.Text,

            };
            users.Add(u);
        }

        private void Btnfajlba_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            if (sf.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sf.FileName, false, Encoding.UTF8))
            {
                foreach (var u in users)
                {
                    sw.Write(u.ID);
                    sw.Write(";");
                    sw.Write(u.FullName);
                    sw.WriteLine();
                }

            }
        }

        private void Listtorol_Click(object sender, EventArgs e)
        {
            User torlendo = (User)listUsers.SelectedItem;
            users.Remove(torlendo);            
            
        }
    }
}
