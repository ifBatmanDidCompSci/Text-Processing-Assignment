namespace Text_Processing_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Vowels()
        {
            try
            {
                string userInput = sentenceTB.Text;
                //to hold number of vowels
                int numberOfVowels = 0;
                //to define the number of characters in userInput
                int characters = userInput.Length;
                //to keep track of which character we're on
                for (int i = 0; i < characters; i++)
                {
                    //go through each character and check them for vowels
                    if (userInput[i] == 'a' || userInput[i] == 'e' || userInput[i] == 'i' || userInput[i] == 'o' || userInput[i] == 'u' || userInput[i] == 'A' || userInput[i] == 'E' || userInput[i] == 'I' || userInput[i] == 'O' || userInput[i] == 'U')
                    {
                        numberOfVowels++;
                    }
                }
                //display the number of vowels in the correct label
                numberOfVowelsLabel.Text = numberOfVowels.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
        private void Words()
        {
            try
            {
                //to get rid of any extra spaces before or after the input phrase
                string userInput = sentenceTB.Text.Trim();
                //get the tokens from the string
                //using a for loop in case there's multiple spaces in between words
                string[] tokens = userInput.Split();
                //to hold the amount of words in the text
                int numberOfWords = 0;
                foreach (string s in tokens)
                {
                    numberOfWords++;
                }
                numberOfWordsActualLabel.Text = numberOfWords.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
;           }
        }
        private void CapitalLetters()
        {
            //use ToUpper and tokenizing to capitilize the first
            //letter after a period
            try
            {
                //make all letters lowercase
                sentenceTB.Text = sentenceTB.Text.ToLower();
                //to get rid of any extra spaces before or after the input phrase
                string userInput = sentenceTB.Text.Trim();
                //convert the string to a char
                char[] letters = userInput.ToCharArray();
                //capitalize the first letter in the string
                letters[0] = char.ToUpper(letters[0]);
                //check for spaces and .,!,and ?, and capitalize the letters following the spaces
                for(int i = 1; i < letters.Length; i++)
                {
                    if(letters[i-1] == ' ' && letters[i-2] == '.')
                    {
                        letters[i] = char.ToUpper(letters[i]);
                    }
                    else if(letters[i - 1] == ' ' && letters[i - 2] == '!')
                    {
                        letters[i] = char.ToUpper(letters[i]);
                    }
                    else if(letters[i - 1] == ' ' && letters[i - 2] == '?')
                    {
                        letters[i] = char.ToUpper(letters[i]);
                    }

                //read each character and add it to the correct label
                }
                foreach(char s in letters)
                {
                    correctCapitilizationLabel.Text += s.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            Vowels();
            Words();
            CapitalLetters();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exit the program
            this.Close();
        }

        private void correctCapitilizationLab_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            correctCapitilizationLabel.Text = null;
            numberOfVowelsLabel.Text = null;
            numberOfWordsActualLabel.Text = null;
            sentenceTB.Text = null;
            sentenceTB.Focus();
        }
    }
}