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
    public partial class result : Form
    {
        public result()
        {
            InitializeComponent();
        }
        List<Result> results;
        int current_count = 0;
        private void result_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(LoginInfo.learner.PhotoURL);
            label4.Text = LoginInfo.learner.LearnerId;
            label5.Text = "" + LoginInfo.learner.F_Name + " " + LoginInfo.learner.M_Name + " " + LoginInfo.learner.L_Name;

            label7.Text = LoginInfo.learner.Email;

            DBEF te = new DBEF();
            var results =te.Results.Where(x => x.LearnerId == LoginInfo.learner.LearnerId).ToList();
            this.results = results;
            if ( results.Count == 0)
            {
                
                chpter.Text = "";
                standard.Text = "";
                subject.Text = "";
                total.Text = "";
                Obtained.Text = "";
                quizon.Text = "";
                performence.Text = "";
                label8.Text = "Whenever You make any submission Hear All Results will mention";
                button3.Enabled = false;
                button2.Enabled = true;
                label9.Text = "0" ;

            }
            else
            {
                chpter.Text = results[this.current_count].chepter ;
                standard.Text = results[this.current_count].std;
                subject.Text = results[this.current_count].Subject;
                total.Text = ""+results[this.current_count].Total;
                Obtained.Text = ""+results[this.current_count].Obtained;
                quizon.Text = results[this.current_count].QuizOn.ToString();
                Double per = results[this.current_count].Obtained / 1.00F;
                per /= results[this.current_count].Total;
                per *= 100;  
                performence.Text =Convert.ToString(per) +"%";
                if (this.current_count == results.Count - 1)
                {
                    button3.Enabled = false;
                }
                if(this.current_count == 0)
                {
                    button2.Enabled = false;
                }
                label9.Text = "" + (this.results.Count - this.current_count - 1) + "/" + this.results.Count;


            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.current_count += 1;
            if (current_count == this.results.Count - 1)
            {
                button3.Enabled = false;

            }
            label17.Text = "R" + (this.current_count + 1);
            chpter.Text = results[this.current_count].chepter;
            standard.Text = results[this.current_count].std;
            subject.Text = results[this.current_count].Subject;
            total.Text = "" + results[this.current_count].Total;
            Obtained.Text = "" + results[this.current_count].Obtained;
            quizon.Text = results[this.current_count].QuizOn.ToString();
            Double per = results[this.current_count].Obtained / 1.00F;
            per /= results[this.current_count].Total;
            per *= 100;
            performence.Text = Convert.ToString(per) + "%";

            label9.Text = "" + (this.results.Count - this.current_count - 1) + "/" + this.results.Count;

            if (current_count == 0)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.current_count -= 1;



            if (current_count == this.results.Count - 1)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }

            if (current_count == -1)
            {
                button2.Enabled = false;
            }
            else
            {
                label9.Text = "" + (this.results.Count - this.current_count - 1) + "/" + this.results.Count;
                label17.Text = "R" + (this.current_count + 1);
                chpter.Text = results[this.current_count].chepter;
                standard.Text = results[this.current_count].std;
                subject.Text = results[this.current_count].Subject;
                total.Text = "" + results[this.current_count].Total;
                Obtained.Text = "" + results[this.current_count].Obtained;
                quizon.Text = results[this.current_count].QuizOn.ToString();
                Double per = results[this.current_count].Obtained / 1.00F;
                per /= results[this.current_count].Total;
                per *= 100;
                performence.Text = Convert.ToString(per) + "%";
                button2.Enabled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoginInfo.UserID = "";
            LoginInfo.learner = null;
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
