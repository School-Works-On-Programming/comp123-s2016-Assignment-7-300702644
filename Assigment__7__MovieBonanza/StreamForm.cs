﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Author : Christopher Ritchil
 * Student # : 300702644
 * Date : August 19th, 2016
 * Version : Final version 
 */

namespace Assigment__7__MovieBonanza
{
    public partial class StreamForm : Form
    {
        //public properties
        public OrderForm orderformprop1 { get; set; }
        /// <summary>
        /// constuctor
        /// </summary>
        public StreamForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this method exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StreamForm_Load(object sender, EventArgs e)
        {

        }
    }
}
