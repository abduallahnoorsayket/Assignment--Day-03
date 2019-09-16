
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayketwindowsForm2
{
    public partial class From03 : Form
    {
        const int size = 4;
        //int[] element = new int[size];
        int userSize = 0;
        int index = 0;

        string[] name = new string[size];


        string[] contact = new string[size];


        string[] address = new string[size];


        string[] quantity = new string[size];

        string[] order = new string[size];




        public From03()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            for (index = 0; index < size; index++)

            {
                richTextBox.Text += "\n\n\tCustomer Name :" + name[index] + "\n\n";
                richTextBox.Text += "\tContact No :" + contact[index] + "\n\n";
                richTextBox.Text += "\tAddress :" + address[index] + "\n\n";

                if (order[index] == "Black-120")
                {
                    int price = Convert.ToInt32(quantity[index]);
                    price = price * 120;

                    richTextBox.Text += "\tOrder:Black\n\n";
                    richTextBox.Text += "\tTotal Price :" + price + "\n\n";
                    //richTextBox.Text += "\tPrice per Unit :" + 120 + "\n\n";
                }

                else if (order[index] == "Cold-100")
                {


                    int price = Convert.ToInt32(quantity[index]);
                    price = price * 100;

                    richTextBox.Text += "\tOrder: Cold \n\n";
                    richTextBox.Text += "\tTotal Price :" + price + "\n\n";
                   // richTextBox.Text += "\tPrice per Unit :" + 100 + "\n\n";

                }

                else if (order[index] == "Hot-90")
                {


                    int price = Convert.ToInt32(quantity[index]);
                    price = price * 90;
                    richTextBox.Text += "\tOrder: Hot \n\n";
                    richTextBox.Text += "\tTotal Price :" + price + "\n\n";
                   // richTextBox.Text += "\tPrice per Unit :" + 90 + "\n\n";

                }


                else if (order[index] == "Regular-80")
                {


                    int price = Convert.ToInt32(quantity[index]);
                    price = price * 80;
                    richTextBox.Text += "\tOrder: Regular\n\n";
                    richTextBox.Text += "\tTotal Price :" + price + "\n\n";
                    //richTextBox.Text += "\tPrice per Unit :" + 80 + "\n\n";

                }

                else
                {
                    richTextBox.Text += "\tPlease Select Item ";
                }

                richTextBox.Text += "\tQuantity :" + quantity[index] + "\n\n";

            }


        }

          
           


            
            private void button2_Click(object sender, EventArgs e)
            {

                if (index < size)
                {

                name[index] = nameTextBox.Text;
                contact[index] = contactNoTextBox.Text;
                address[index] = addressTextBox.Text;
                order[index] = orderComboBox.Text;
               

                quantity[index] = quantityTextBox.Text;
                index++;

                }

                else
                {
                MessageBox.Show("Element is full!");
                }

            }




    }
}
