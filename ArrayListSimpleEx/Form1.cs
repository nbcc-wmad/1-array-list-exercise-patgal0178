using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        private ArrayList words = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            words.Add("I");
            words.Add("Love");
            words.Add("Programming");
            words.Add("So");
            words.Add("Much");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            words.Insert(1, txtSecondPos.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            words.RemoveAt(1);
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            string message;
            if (words.Count == 6)
            {
                message = words[0] + " " + words[1] + " " + words[2] + " " + words[3] + " " + words[4] + " " + words[5];
            }
            else
            {
                message = words[0] + " " + words[1] + " " + words[2] + " " + words[3] + " " + words[4];
            }
            lblMessage.Text = message;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            string egassem;

            if (words.Count == 6)
            {
                egassem = words[5] + " " + words[4] + " " + words[3] + " " + words[2] + " " + words[1] + " " + words[0];
            }
            else
            {
                egassem = words[4] + " " + words[3] + " " + words[2] + " " + words[1] + " " + words[0];
            }
            lblMessage.Text = egassem;
        }
    }
}
