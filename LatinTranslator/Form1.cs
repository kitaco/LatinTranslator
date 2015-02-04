using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatinTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sinsterButton_Click(object sender, EventArgs e)
        {
            translatedLabel.Text = "Left";
        }

        private void dexterButton_Click(object sender, EventArgs e)
        {
            translatedLabel.Text = "Right";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            translatedLabel.Text = "Center";
        }
    }
}
