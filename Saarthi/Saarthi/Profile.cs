using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
           
            pictureBox1.Image = Image.FromFile(LoginInfo.learner.PhotoURL);
            label1.Text = LoginInfo.learner.F_Name;
            label4.Text = LoginInfo.learner.LearnerId;
            label5.Text = ""+ LoginInfo.learner.F_Name +" "+ LoginInfo.learner.M_Name  + " "+ LoginInfo.learner.L_Name;
            
            label7.Text = LoginInfo.learner.Email;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Quiz q = new Quiz();
            q.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            result r = new result();
                r.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoginInfo.UserID = "";
            LoginInfo.learner = null;
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
