using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
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
            Application.Run(new Home());

            //dbef te = new dbef();
            //learner tl = new learner();
            //tl.email = "dfas";
            //tl.f_name = "fhj";
            //tl.l_name = "djhgfbk";
            //tl.password = "fgda";
            //tl.confpassword = "fgda";
            ////tl.m_name = "hjdfsa";
            //tl.learnerid = "4";
            //te.learners.add(tl);
            //te.savechanges();

        }
    }
}
