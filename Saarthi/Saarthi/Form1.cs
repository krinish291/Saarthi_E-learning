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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBEF te = new DBEF();
            List<Learner> tll = new List<Learner>();

            tll = te.Learners.ToList();
          
            dataGridView2.DataSource = tll;
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
                prf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
