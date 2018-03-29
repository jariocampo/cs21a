// Vianne Borja 150614
//Jari Ocampo 153070
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConsoleApplication5
{
    public partial class UGH : Form
    {
        bool clickButton;
        List<int> number = new List<int>();

        public UGH()
        {
            InitializeComponent();
            clickButton = false;

        }

        private void numberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {
            int min;
            int temp;
            if (number.Count > 1)
            {
                clickButton = true;

                Results.Text = "Initial Order: \r\n";

                for (int i = 0; i < number.Count; i++)
                {
                    Results.Text += (number.ElementAt(i)) + " ";
                }

                Results.Text += "\r\n" + "\r\n";
                Results.Text += "Sorting Process: \r\n";

                for (int i = 0; i < number.Count - 1; i++)
                {
                    min = i;
                    for (int j = i + 1; j < number.Count; j++)
                    {
                        if (number[min] > number[j])
                        {
                            min = j;
                        }
                    }
                    temp = number[i];
                    number[i] = number[min];
                    number[min] = temp;
                    for (int x = 0; x < number.Count; x++)
                    {
                        Results.Text += number[x] + " ";
                    }
                    Results.Text += "\r\n";
                }
                Results.Text += "\r\n";
                Results.Text += "Final Order: \r\n";

                for (int k = 0; k < number.Count; k++)
                {
                    Results.Text += (number.ElementAt(k)) + " ";
                }

            }
            else if (number.Count == 1)
            {
                clickButton = true;

                Results.Text = "Initial Order: \r\n" + (number.ElementAt(0)) + "\r\n" + "\r\n";
                Results.Text += "Final Order: \r\n" + (number.ElementAt(0));
            }
            else
            {
                Results.Text = "ERROR: 0 integers added. Please add at least 1 integer. \r\n \r\n";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void binsertion_Click(object sender, EventArgs e)
        {
            if (number.Count > 1)
            {
                clickButton = true;

                Results.Text = "Initial Order: \r\n";

                for (int i = 0; i < number.Count; i++)
                {
                    Results.Text += (number.ElementAt(i)) + " ";
                }

                Results.Text += "\r\n" + "\r\n";
                Results.Text += "Sorting Process: \r\n";

                for (int i = 1; i <= number.Count - 1; i++)
                {
                    int ins = number[i];
                    int p = binarySearch(number, i - 1, ins);

                    for (int j = i - 1; j >= p; j--)
                    {
                        number[j + 1] = number[j];
                    }
                    number[p] = ins;

                    foreach (int element in number)
                    {
                        Results.Text += element.ToString() + " ";
                    }
                    Results.Text += "\r\n";
                }


                Results.Text += "\r\n";
                Results.Text += "Final Order: \r\n";

                for (int i = 0; i < number.Count; i++)
                {
                    Results.Text += (number.ElementAt(i)) + " ";
                }
            }
            else if (number.Count == 1)
            {
                clickButton = true;

                Results.Text = "Initial Order: \r\n" + (number.ElementAt(0)) + "\r\n" + "\r\n";
                Results.Text += "Final Order: \r\n" + (number.ElementAt(0));
            }
            else
            {
                Results.Text = "ERROR: 0 integers added. Please add at least 1 integer. \r\n \r\n";
            }
        }

        public int binarySearch(Object A, int searchSize, int searchItem)
        {
            int initialIndex = 0;
            int midIndex = searchSize / 2;
            int finalIndex = searchSize;
            while (initialIndex < finalIndex)
            {
                if (searchItem < number[midIndex])
                {
                    finalIndex = midIndex - 1;
                }
                else if (searchItem > number[midIndex])
                {
                    initialIndex = midIndex + 1;
                }
                else
                {
                    initialIndex = midIndex;
                    finalIndex = midIndex;
                }
                midIndex = ((finalIndex + initialIndex) / 2);
            }
            if (searchItem <= number[initialIndex])
            {
                return initialIndex;
            }
            else
            {
                return initialIndex + 1;
            }
        }

        private void UGH_Load(object sender, EventArgs e)
        {

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Results.Clear();
            number.Clear();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (clickButton == false)
            {
                number.Add(int.Parse(enterbox.Text));
                Results.Text += "Number" + " " + enterbox.Text + " " + "added to list." + "\r\n";
            }
            else
            {
                Results.Text = "ERROR: Sorting has finished. If you wish to add more integers, please restart the program.";
            }

            enterbox.Text = "";
        }

        private void Bubbly_Click(object sender, EventArgs e)
        {

            if (number.Count > 1)
            {
                clickButton = true;

                Results.Text = "Initial Order: \r\n";

                for (int i = 0; i < number.Count; i++)
                {
                    Results.Text += (number.ElementAt(i)) + " ";
                }

                Results.Text += "\r\n" + "\r\n";
                Results.Text += "Sorting Process: \r\n";

                for (int p = 1; p <= number.Count / 2; p++)
                {
                    for (int i = p - 1; i <= (number.Count - 1) - p; i++)
                    {
                        if (number[i] > number[i + 1])
                        {
                            int temp = number[i];
                            number[i] = number[i + 1];
                            number[i + 1] = temp;
                        }
                    }
                    for (int i = number.Count - p - 1; i >= p; i--)
                    {
                        if (number[i] < number[i - 1])
                        {
                            int temp = number[i];
                            number[i] = number[i - 1];
                            number[i - 1] = temp;
                        }
                    }

                    foreach (int element in number)
                    {
                        Results.Text += element.ToString() + " ";
                    }
                    Results.Text += "\r\n";
                }

                Results.Text += "\r\n";
                Results.Text += "Final Order: \r\n";

                for (int i = 0; i < number.Count; i++)
                {
                    Results.Text += (number.ElementAt(i)) + " ";
                }

            }
            else if (number.Count == 1)
            {
                clickButton = true;

                Results.Text = "Initial Order: \r\n" + (number.ElementAt(0)) + "\r\n" + "\r\n";
                Results.Text += "Final Order: \r\n" + (number.ElementAt(0));
            }
            else
            {
                Results.Text = "ERROR: 0 integers added. Please add at least 1 integer. \r\n \r\n";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
    
