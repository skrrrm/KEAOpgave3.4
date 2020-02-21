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
 * Udvid eventuelt programmet så antallet af rigtige og forkerte svar kan opgøres.
*/
namespace KEAOpgave3._4
{
    public partial class Form1 : Form
    {
        // Variabler
        Random random1 = new Random();
        double first, second, result, userResult;
        int countWrong = 0, countCorrect = 0;

        private void buttonReset_Click(object sender, EventArgs e) // Reset button 
        {
            // Should have made this into a method
            first = Convert.ToDouble(random1.Next(0, 10)); // Random number is put into the variable 'first'
            second = Convert.ToDouble(random1.Next(0, 10)); // Random number is put into the variable 'second'
            result = first * second; // We do the calculation already so we can check the user calculation later
            labelInfo.Text = $"What is {first} multiplied by {second}?"; // Info text.
            labelResult.Text = "";
            textBoxResult.Text = "";
        }

        public Form1()
        {
            InitializeComponent();

            // Should have made this into a method
            first = Convert.ToDouble(random1.Next(0, 10)); // Random number is put into the variable 'first'
            second = Convert.ToDouble(random1.Next(0, 10)); // Random number is put into the variable 'second'
            result = first * second; // We do the calculation already so we can check the user calculation later
            labelInfo.Text = $"What is {first} multiplied by {second}?"; // Info text
        }

        private void button1_Click(object sender, EventArgs e) // Calculate button
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
            {
                labelResult.Text = "Correct!";
                labelCorrect.Text = $"You've got {countCorrect = countCorrect + 1} correct answers";
                // Counts the score of correct answers
            }
            else if (result != userResult) // We compare user-result with actual result, if incorrect..
            {
                labelResult.Text = $"Incorrect! The result is {result}";
                labelWrong.Text = $"You've got {countWrong = countWrong + 1 } wrong answers";
                // Counts the score of wrong answers
            }
        }
    }
}
