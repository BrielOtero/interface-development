﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_exercise
{
    public partial class Pin : Form
    {
        private int pinNumber = 1234;
        private int tries = 3;
        private bool find = false;
        public Pin()
        {
            InitializeComponent();
            this.Text = "Insert Pin";
            textBox1.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkPin();
        }


        private void checkPin()
        {
            bool valid = int.TryParse(textBox1.Text, out int pin);

            Trace.WriteLine(valid);
            if (valid)
            {
                if (pin == pinNumber)
                {
                    this.DialogResult = DialogResult.OK;
                    find = true;
                    this.Close();
                }
            }

            tries--;

            if (tries < 0)
            {
                this.DialogResult = DialogResult.Cancel;
                Environment.Exit(0);
            }
            else
            {
                label2.Text = $"{tries} tries left";
            }
        }

        private void Pin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!find)
            {
                e.Cancel = true;
                Environment.Exit(0);
            }
        }
    }
}
