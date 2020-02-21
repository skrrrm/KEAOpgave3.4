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
        double first, second, result, userResult;

        public Form1()
        {
            InitializeComponent();
            first = Convert.ToDouble(random1.Next(0, 10)); // Random number is put into the variable 'first'
            second = Convert.ToDouble(random2.Next(0, 10)); // Random number is put into the variable 'second'
            result = first * second; // We do the calculation already so we can check the user calculation later
            labelInfo.Text = $"What is {first} multiplied by {second}?"; // Info text

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                userResult = Convert.ToDouble(textBoxResult.Text); // checking the entered result is a double/number
            }
            catch
            {
                labelError.Text = "Numbers only!"; // Error
            }

            if (result == userResult) // We compare user-result with the actual result, if correct..
                labelResult.Text = "Correct!";
            else if (result != userResult) // We compare user-result with actual result, if incorrect..
                labelResult.Text = $"Incorrect! The result is {result}";
        }
    }
}
