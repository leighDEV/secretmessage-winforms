using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secretmessage_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clicking the show button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (btnShow.Text == "SHOW HIDDEN MESSAGE") // show button
            {
                lblMessage.Text = "hehe.";
                btnShow.Text = "HIDE HIDDEN MESSAGE";
            }
            else // hide button
            {
                lblMessage.ResetText();
                btnShow.Text = "SHOW HIDDEN MESSAGE";
            }
        }
    }
}