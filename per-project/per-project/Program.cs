using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static per_project.Class1;

namespace per_project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // creting form connection  it should be before run() and after setcompatible 
            // this be created to make the form moving esier and more smooth 
            Forms.F1 = new Form1();
            Forms.F2 = new Form2();
            Forms.F3 = new Form3();
            Forms.F4 = new Form4();
            Forms.F5 = new Form5();
            Forms.F6 = new Form6();


            Application.Run(new Form1());

           

        }
    }
}
