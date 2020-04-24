using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBEF te = new DBEF();
            List<Learner> tll = new List<Learner>();
            List<Standard> stdll = new List<Standard>();
            tll = te.Learners.ToList();
            stdll = te.Standards.ToList();
   //         dataGridView1.DataSource = stdll;
  //          dataGridView2.DataSource = tll;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBEF te = new DBEF();
            var email = uname.Text;
            var password = pswd.Text;
            var learner=te.Learners.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
            if(learner != null)
            {
                Profile prf = new Profile();
                LoginInfo.UserID = email;
                LoginInfo.learner = learner;
                if (LoginInfo.learner.F_Name == "ADMIN")
                {
                    Admin a = new Admin();
                    a.Show();
                    this.Hide();
                }
                else
                {
                    prf.Show();
                    this.Hide();

                }
                
            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
                this.Hide();

        }
    }
}
