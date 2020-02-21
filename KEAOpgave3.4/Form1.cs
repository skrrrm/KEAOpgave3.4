using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Skriv et program, der tester brugerens evner til hovedregning.
 * Programmet skal ved tryk på knap stille et gangestykke, 
 * hvor faktorerne er hele tal mellem 0 og 10.
 * Brugeren taster resultatet ind (husk, at indtastning i en textBox ikke er tal).
 * Programmet skal angive om facit er rigtigt eller forkert. 
 * Hvis facit er forkert skal det rigtige facit angives.
*/
namespace KEAOpgave3._4
{
    public partial class Form1 : Form
    {
        // Variabler
        Random random1 = new Random();
        Random random2 = new Random();
        double first, second, result, doubleTextboxResult;

        public Form1()
        {
            InitializeComponent();
            first = Convert.ToDouble(random1.Next(0, 10));
            second = Convert.ToDouble(random2.Next(0, 10));
            result = first * second;
            labelInfo.Text = $"What is {first} multiplied by {second}?";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                doubleTextboxResult = Convert.ToDouble(textBoxResult.Text);
            }
            catch
            {
                labelError.Text = "Numbers only";
            }

            if (result == doubleTextboxResult)
                labelResult.Text = "Correct!";
            else if (result != doubleTextboxResult)
                labelResult.Text = $"Incorrect! The result is {result}";
        }
    }
}
