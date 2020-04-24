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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {




            //var learner = te.Learners.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
           

        }

        private void uploadPhoto_Click(object sender, EventArgs e)
        {
         
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void uploadPhoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png;)|*.jpg;*.jpeg;.*.gif;*.png;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void register_Click_1(object sender, EventArgs e)
        {
            DBEF saarthi = new DBEF();
            var fnm = fname.Text;
            var lnm = lname.Text;
            var mnm = mname.Text;
            var eml = email.Text;
            var pswd = password.Text;
            var cpswd = confpassword.Text;

            if (pswd != cpswd)
            {
                MessageBox.Show("Password and Confirm Password is not match Kindly Check!!");
            }
            else if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Select an image");
            }
            else
            {
                var learner = saarthi.Learners.Where(x => x.Email == eml).FirstOrDefault();
                if (learner != null)
                {
                    MessageBox.Show("This Email Id is Already Registerd Login With it!!!");

                }
                else
                {
                    Learner l = new Learner();
                    l.Email = eml;
                    l.F_Name = fnm;
                    l.L_Name = lnm;
                    l.M_Name = mnm;
                    l.Password = pswd;
                    l.LearnerId = "L" + DateTime.Now.Year + "" + DateTime.Now.GetHashCode().ToString().Substring(4);

                    if (pictureBox1.Image != null)
                    {
                        l.PhotoURL = @"C:\Users\RADADIYA KRINISH\Desktop\Krinish\Myproject\Myproject\Saarthi_E-learning\Saarthi\Saarthi\AppData\profilePic\" + l.LearnerId + ".bmp";
                        pictureBox1.Image.Save(l.PhotoURL, System.Drawing.Imaging.ImageFormat.Bmp);
                        saarthi.Learners.Add(l);
                        saarthi.SaveChanges();
                        //label8.Text = "Congratulations!!! You are registerd Please Login..";
                        MessageBox.Show("Congratulations!!! You are registerd Please Login..");
                    }
                    else
                    {
                        MessageBox.Show("Please enter Yoyr Profile Pic");

                    }




                }
            }


        }
    }
}
