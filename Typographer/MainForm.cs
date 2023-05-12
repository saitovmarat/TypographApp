using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Typograph
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button.BorderStyle = BorderStyle.Fixed3D;  
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (Button.BorderStyle == BorderStyle.Fixed3D)
            {
                Button.BorderStyle = BorderStyle.FixedSingle;
            }
            
        }
        private void Button_Click(object sender, EventArgs e)
        {
            string text = textBox.Text;

            text = Rules.MainPart(text);
            
            textBox.Text = text;
            textBox.SelectionStart = textBox.Text.Length;
            textBox.ScrollToCaret();
        }

        
    }
}
