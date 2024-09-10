using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WootenT_PigLatin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterSentenceLabel_Click(object sender, EventArgs e)
        {

        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Gettign first letter
                char firstLetter;

                //Getting the rest of the word
                string restOfWord = "";

                //Making a full pig latin word
                string pigLatinWord = "";

                //Getting the sentence
                string pigLatinSentence = "";

                //Get every word from the textbox
                string user = userTextBox.Text.ToString();

                //Getting the delimeter of spaces and the words
                string[] words = user.Split(null);


                //Looping through each word in the array of words
                foreach (string word in words)
                {
                    //Breaking down each letter
                    if (word.Length > 1)
                    {
                        //Getting first letter
                        firstLetter = word[0];

                        //Remove first letter
                        restOfWord = word.Remove(0,1);


                        //Putting it all together
                        pigLatinWord = restOfWord + firstLetter + "ay ";

                        //Adding it to the sentence variable
                        pigLatinSentence += pigLatinWord;


                    }
                    else
                    {
                        // If the word is just one letter (like "I"), just add "ay"
                        pigLatinSentence += word + "ay " ;

                    }


                }

                //Adding to output label and makinf it all uppercase
                outcomelabel.Text = pigLatinSentence.ToString().ToUpper();


            }
            catch
            {
                MessageBox.Show("An error has occurred");
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears everything
            userTextBox.Clear();
            outcomelabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Press "ESC" or "ALT + x"
            this.Close();
        }
    }
}
