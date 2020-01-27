using Saarthi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saarthi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            DBEF te = new DBEF();
            Learner tl = new Learner();
            tl.Email = "dfas";
            tl.F_Name = "fhj";
            tl.L_Name = "djhgfbk";
            tl.Password = "fgda";
            tl.confPassWord = "fgda";
            tl.M_Name = "hjdfsa";
            tl.LearnerId = "13572";
            te.Learners.Add(tl);
            te.SaveChanges();

        }
    }
}
