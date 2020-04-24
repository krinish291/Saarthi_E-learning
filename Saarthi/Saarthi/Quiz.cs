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
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
           
        }
        int currunt_count = 0;
        List<Question> quiz_questions;
        int answer = 0;
        string chp;
        string std;
        string sub;
        private void Quiz_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saarthiDBDataSet3.Standards' table. You can move, or remove it, as needed.
            this.standardsTableAdapter1.Fill(this.saarthiDBDataSet3.Standards);
            // TODO: This line of code loads data into the 'saarthiDBDataSet2.Standards' table. You can move, or remove it, as needed.
            //this.standardsTableAdapter.Fill(this.saarthiDBDataSet2.Standards);
            pictureBox1.Image = Image.FromFile(LoginInfo.learner.PhotoURL);
            label4.Text = LoginInfo.learner.LearnerId;
            label5.Text = "" + LoginInfo.learner.F_Name + " " + LoginInfo.learner.M_Name + " " + LoginInfo.learner.L_Name;

            label7.Text = LoginInfo.learner.Email;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            panel.Visible = false;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.Show();
            this.Hide();

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            DBEF te = new DBEF();
            var stdQparameter = "std" + 1;
            List<Subject> subList = te.Subjects.Where(x => x.StandardId == stdQparameter).ToList();
            

          
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.standardsTableAdapter.FillBy(this.saarthiDBDataSet2.Standards);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBEF te = new DBEF();
            var stdQparameter = comboBox1.SelectedValue.ToString();
            var subList = te.Subjects.Where(x => x.StandardId == stdQparameter);
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            foreach (var item in subList)
            {
                comboSource.Add(item.Id,item.Sub_Name);
            }
            
            comboBox2.DataSource = new BindingSource(comboSource, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
             string key = ((KeyValuePair<string, string>)comboBox2.SelectedItem).Key;
            string value = ((KeyValuePair<string, string>)comboBox2.SelectedItem).Value;
            if(comboBox2.SelectedIndex == 0)
            {

            }
            DBEF te = new DBEF();
            var subQparameter = key;
            var ChpList = te.Chapters.Where(x => x.SubjectId == subQparameter);
            Dictionary<string, string> combo2Source = new Dictionary<string, string>();
            foreach (var item in ChpList)
            {
                combo2Source.Add(item.Id, item.Chp_Name);
            }
            comboBox3.DataSource = new BindingSource(combo2Source, null);
            comboBox3.DisplayMember = "Value";
            comboBox3.ValueMember = "Key";

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = ((KeyValuePair<string, string>)comboBox3.SelectedItem).Key;
            string value = ((KeyValuePair<string, string>)comboBox3.SelectedItem).Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = ((KeyValuePair<string, string>)comboBox3.SelectedItem).Key;
            DBEF te = new DBEF();
            this.quiz_questions = te.Questions.Where(x => x.ChapterId == key).ToList();

            var chepter = te.Chapters.Where(x => x.Id == key).FirstOrDefault();
            var subject = te.Subjects.Where(x => x.Id == chepter.SubjectId).FirstOrDefault();
            var stdd = te.Standards.Where(x => x.Id == subject.StandardId).First();
            this.chp = chepter.Chp_Name;
            this.std = ""+(stdd.std_number);
            this.sub = subject.Sub_Name;
            tableLayoutPanel2.Visible = false;
            panel.Visible = true;
            QNO.Text = "1";
            QuestionDesc.Text = this.quiz_questions[this.currunt_count].Statment;

            radioButton1.Text = this.quiz_questions[this.currunt_count].OptionA;
            radioButton2.Text = this.quiz_questions[this.currunt_count].OptionB;
            radioButton3.Text = this.quiz_questions[this.currunt_count].OptionC;
            radioButton4.Text = this.quiz_questions[this.currunt_count].OptionD;

            label9.Text = (quiz_questions.Count - currunt_count - 1) + "/" + (quiz_questions.Count);
            result.Text = "";

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result r = new Result();
            r.Total = this.quiz_questions.Count;
            r.Obtained = this.answer;
            r.chepter = this.chp;
            r.std = this.std;
            r.Subject = this.sub;
            r.LearnerId = LoginInfo.learner.LearnerId;
            r.QuizOn = DateTime.Now;
            r.Id = "QUIZ" + DateTime.Now.Date + "" + DateTime.Now.GetHashCode().ToString().Substring(4);
            DBEF te = new DBEF();
            te.Results.Add(r);
            te.SaveChanges();
            panel.Visible = false;
            tableLayoutPanel2.Visible = true;
            result.Text = "Your Score is "+ r.Obtained + "/" + r.Total;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ans = this.quiz_questions[this.currunt_count].Correct;
            if(!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Please select An Option");
            }
            else
            {
                if (ans == "A")
                {
                    if (radioButton1.Checked)
                    {
                        this.answer += 1;
                    }
                }
                else if (ans == "B")
                {
                    if (radioButton2.Checked)
                    {
                        this.answer += 1;
                    }

                }
                else if (ans == "C")
                {
                    if (radioButton3.Checked)
                    {
                        this.answer += 1;
                    }

                }
                else if (ans == "D")
                {

                    if (radioButton4.Checked)
                    {
                        this.answer += 1;
                    }
                }

                this.currunt_count += 1;
                QNO.Text = "" + (this.currunt_count +  1);
                QuestionDesc.Text = this.quiz_questions[this.currunt_count].Statment;

                radioButton1.Text = this.quiz_questions[this.currunt_count].OptionA;
                radioButton2.Text = this.quiz_questions[this.currunt_count].OptionB;
                radioButton3.Text = this.quiz_questions[this.currunt_count].OptionC;
                radioButton4.Text = this.quiz_questions[this.currunt_count].OptionD;

                label9.Text = (quiz_questions.Count - currunt_count - 1) + "/" + (this.quiz_questions.Count);
                if (this.currunt_count == this.quiz_questions.Count - 1)
                {
                    button3.Enabled = false;
                }
                radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = false;
            }
         

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
