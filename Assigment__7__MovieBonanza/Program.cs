using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Author : Christopher Ritchil
 * Student # : 300702644
 * Date Created : August 19th, 2016
 * Date updated: August 19th, 2016
 * Description : This application demonstrate Movie Bonanza  for COMP123 programming II Assignment
 * Version : Final version 
 */

namespace Assigment__7__MovieBonanza
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
        }
    }
}
