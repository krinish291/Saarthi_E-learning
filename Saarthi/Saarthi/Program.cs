using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public static class LoginInfo
    {
        public static string UserID;
        public static Learner learner;
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {/*
            List<String> subject = new List<string>() { "Gujrati", "Maths", "English", "Social Science", "Science" };
           
            int count = 245;
            DBEF te = new DBEF();
            Chapter ch = new Chapter();
            ch.Chp_Name = "Magnet";
            ch.Id = "GSEBSUB" + "SCI" +"CH"+ count++;
            ch.SubjectId = "GSEBSTD006SUB562";
            te.Chapters.Add(ch);
            te.SaveChanges();

            */
            Question q = new Question();
            q.Statment = "This i s A first Question";
            q.OptionA = "A";
            q.OptionB = "A";
            q.OptionC = "A";
            q.OptionD = "A";
            q.Correct = "A";
            q.Id = "FIRST";
            q.ChapterId = "GSEBSUBSCICH245";
            //DBEF te = new DBEF();
            //te.Questions.Add(q);
           // te.SaveChanges();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());

           
        }
    }
}
