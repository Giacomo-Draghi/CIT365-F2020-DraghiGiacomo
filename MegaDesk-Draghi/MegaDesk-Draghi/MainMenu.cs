using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Draghi
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Closes the main Form
            Close();
        }

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {

        }

        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
