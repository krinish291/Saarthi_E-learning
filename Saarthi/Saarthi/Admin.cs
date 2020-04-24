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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saarthiDBDataSet4.Standards' table. You can move, or remove it, as needed.
            this.standardsTableAdapter1.Fill(this.saarthiDBDataSet4.Standards);
            // TODO: This line of code loads data into the 'saarthiDBDataSet2.Standards' table. You can move, or remove it, as needed.
          //  this.standardsTableAdapter.Fill(this.saarthiDBDataSet2.Standards);
            pictureBox1.Image = Image.FromFile(LoginInfo.learner.PhotoURL);
            label4.Text = LoginInfo.learner.LearnerId;
            label5.Text = "" + LoginInfo.learner.F_Name + " " + LoginInfo.learner.M_Name + " " + LoginInfo.learner.L_Name;

            label7.Text = LoginInfo.learner.Email;
            comboBox4.Items.Add("A");
            comboBox4.Items.Add("B");
            comboBox4.Items.Add("C");
            comboBox4.Items.Add("D");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBEF te = new DBEF();
            var stdQparameter = comboBox1.SelectedValue.ToString();
            var subList = te.Subjects.Where(x => x.StandardId == stdQparameter);
         
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            foreach (var item in subList)
            {
                comboSource.Add(item.Id, item.Sub_Name);
            }

            comboBox2.DataSource = new BindingSource(comboSource, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = ((KeyValuePair<string, string>)comboBox2.SelectedItem).Key;
            string value = ((KeyValuePair<string, string>)comboBox2.SelectedItem).Value;
            if (comboBox2.SelectedIndex == 0)
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

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Enter Valid Data");
            }
            else
            {
                DBEF te = new DBEF();
                Question q = new Question();
                q.ChapterId = ((KeyValuePair<string, string>)comboBox3.SelectedItem).Key;
                q.OptionA = textBox1.Text;

                q.OptionB = textBox2.Text;
                q.OptionC = textBox3.Text;
                q.OptionD = textBox4.Text;
                q.Correct = comboBox4.SelectedItem.ToString();
                q.Statment = richTextBox1.Text;
                q.Id = "QU" + q.ChapterId + DateTime.Now.GetHashCode().ToString().Substring(4);

                te.Questions.Add(q);
                te.SaveChanges();
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = richTextBox1.Text = "";

                MessageBox.Show("New Question Added");

            }


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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

