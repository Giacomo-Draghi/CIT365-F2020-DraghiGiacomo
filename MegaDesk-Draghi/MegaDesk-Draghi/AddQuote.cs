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
    public partial class AddQuote : Form
    {

        public AddQuote()
        {
            InitializeComponent();
        }
        //Navigation
        private void SubmitOrder_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }
        //Validating
        private void addWidth_Validaing(object sender, CancelEventArgs e)
        {
            string errorMsg = "Width should be a number between 24 and 96!"; ;
            int value;
            if (int.TryParse(addWidth.Text, out value))
            {
                if (value > 96 || value < 24)
                {
                    e.Cancel = true;
                    addWidth.Select(0, addWidth.Text.Length);
                    // Set the ErrorProvider error with the text to display. 
                    MessageBox.Show(errorMsg,
                                "Invalid Imput!");
                }
                else
                {
                    e.Cancel = false;
                }

            }

            else
            {
                addWidth.Select(0, addWidth.Text.Length);
                e.Cancel = true;
                // Set the ErrorProvider error with the text to display. 
                MessageBox.Show(errorMsg,
                                "Invalid Imput!");
            }
        }

        private void addDepth_Validating(object sender, CancelEventArgs e)
        {

            string errorMsg = "Width should be a number between 12 and 48!"; ;
            int value;
            if (int.TryParse(addDepth.Text, out value))
            {
                if (value > 48 || value < 12)
                {
                    e.Cancel = true;
                    addDepth.Select(0, addDepth.Text.Length);
                    // Set the ErrorProvider error with the text to display. 
                    MessageBox.Show(errorMsg,
                                "Invalid Imput!");
                }
                else
                {
                    e.Cancel = false;
                }

            }

            else
            {
                addDepth.Select(0, addDepth.Text.Length);
                e.Cancel = true;
                // Set the ErrorProvider error with the text to display. 
                MessageBox.Show(errorMsg,
                                "Invalid Imput!");
            }
        }



        //Populating DeskQuote
        private void button1_Click(object sender, EventArgs e)
        {
            DeskQuote d = new DeskQuote(float.Parse(addWidth.Text), float.Parse(addDepth.Text), int.Parse(drawer.Text),
                material.Text, int.Parse(shipping.Text), DateTime.Now.ToString("dd/mm/yy"));
            
            
            string nam = d.Name(name.Text);

            float classAreaPrice = d.AreaPrice(d.width, d.depth);
            areaPrice.Text = classAreaPrice.ToString("0.00");
            drawerPrice.Text = d.DrawerPrice(d.numOfDrawer).ToString("0.00");
            materialPrice.Text = d.MaterialPrice(d.matirial).ToString("0.00");
            shippingPrice.Text = d.ShippingPrice(d.shipping).ToString("0.00");
            total.Text = (classAreaPrice + d.DrawerPrice(d.numOfDrawer) + d.MaterialPrice(d.matirial) + d.ShippingPrice(d.shipping)).ToString("0.00");

            Day.Text = d.date;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }
    } }
