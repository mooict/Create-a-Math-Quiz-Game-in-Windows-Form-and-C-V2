using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maths_Quiz_Version_2_MOO_ICT
{
    public partial class Form1 : Form
    {

        // www.mooict.com
        // project based programming tutoials

        int numA;
        int numB;
        int total;

        Random rnd = new Random();
        string[] Maths = {"Add", "Subtract", "Multiply" };

        string secretAnswer;
        string userChoice;


        public Form1()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {

            numA = rnd.Next(10, 20);
            numB = rnd.Next(0, 9);

            secretAnswer = Maths[rnd.Next(0, Maths.Length)];

            switch (secretAnswer)
            {
                case "Add":
                    total = numA + numB;
                    break;

                case "Subtract":
                    total = numA - numB;
                    break;

                case "Multiply":
                    total = numA * numB;
                    break;
            }

            lblNumA.Text = numA.ToString();
            lblNumB.Text = numB.ToString();
            lblTotal.Text = total.ToString();
            lblSymbol.Text = "?";
        }

        private void CheckAnswer()
        {

            if (userChoice == secretAnswer)
            {
                MessageBox.Show("Correct, Now try again!");
                SetUpGame();
            }
            else
            {
                MessageBox.Show("Incorrect, try again!");
                lblSymbol.Text = "?";
            }


        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Q)
            {
                userChoice = "Add";
                lblSymbol.Text = "+";
                CheckAnswer();
            }
            if (e.KeyCode == Keys.W)
            {
                userChoice = "Subtract";
                lblSymbol.Text = "-";
                CheckAnswer();
            }
            if (e.KeyCode == Keys.E)
            {
                userChoice = "Multiply";
                lblSymbol.Text = "x";
                CheckAnswer();
            }
        }
    }
}
