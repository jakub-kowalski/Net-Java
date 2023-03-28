using LAB1_poprawione;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB1okienko
{
    public partial class BackpackProblem : Form
    {
        public BackpackProblem()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textInputCapacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textInputAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
             if (Int32.TryParse(textInputAmount.Text, out int amount) && Int32.TryParse(textInputCapacity.Text, out int capacity))
             {
                //Stworzenie obiektów
                Random random = new Random(1);
                Backpack backpack = new Backpack(capacity);

                for (int i = 0; i < amount; i++)
                {
                    //Generowanie pseudolosowych wag oraz wartości
                    int weight = random.Next(1, 10);
                    int value = random.Next(1, 20);
                    //Tworzenie obiektów klasy Item
                    Item item = new Item(i, weight, value);
                    //Dodawanie przedmiotów do plecaka
                    backpack.AddItem(item);
                    textOutputItems.Text += amount.ToString();
                    textOutputItems.Text += Environment.NewLine;
                }
        }
             else
             {
                
             }
        }
        

        private void textOutputItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void textOutputSolution_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
