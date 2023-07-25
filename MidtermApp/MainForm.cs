using System.Text.RegularExpressions;

// Created By Muhammad Elsoukkary (2023-06-22)

namespace MidtermApp
{
    public partial class MainForm : Form
    {
        // OOP list that calls on the pateints class
        private List<Patients> _pateints = new List<Patients>();

        public MainForm()
        {
            InitializeComponent();

        }

        private void txtBoxZipCode_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBoxMatchingPhrases_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // delcare regex and make it equal to input text
            string zipCode = txtBoxZipCode.Text;
            Regex zipCodeCheck = new Regex(@"^\d{5}(?:-\d{4})?$");

            // simple if statment that checks if it is correct and outputs result based off that
            if (zipCodeCheck.IsMatch(zipCode))
            {
                MessageBox.Show("Valid zipcode entered");
            }
            else
            {
                MessageBox.Show("Invalid zipcode entered");
            }
        }

        public string RemoveVowels(string inputText)
        {
            // for loop that itrates through the given input text and removes vowels according to that
            string output = "";

            for (int i = 0; i < inputText.Length; i++)
            {
                char c = inputText[i];

                if (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u' &&
                    c != 'A' && c != 'E' && c != 'I' && c != 'O' && c != 'U')
                {
                    output += c;
                }

            }
            // then returns the output and and makes it equal to the label that will display the new output

            lblInputTexChanged.Text = output;
            return output;


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        // sets the values and error messages 
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblErrorMessages.Text = "";
            ResetFields();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // delcare ints of age and converts it 
            int age;
            bool isAgeValid = int.TryParse(txtBoxAge.Text, out age);
            string fullName = txtBoxFullName.Text;

            string recordNumber = txtBoxRecordNumber.Text;

            try
            {
                // try to create a pateint record object:
                Patients patients = new Patients(age, fullName, recordNumber);

                // and then store it in our list:
                _pateints.Add(patients);

                // and let user know we stored it :
                MessageBox.Show("Pateint was recorded!");
                ResetFields();
            }
            catch (InvalidDataException ex)
            {
                SetErrMessage(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        // helper method 
        private void ResetFields()
        {
            txtBoxAge.Text = "";
            txtBoxFullName.Text = "";
            txtBoxInputText.Text = "";
            txtBoxRecordNumber.Text = "";
            txtBoxZipCode.Text = "";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        // sets the error messages 

        private void SetErrMessage(string msg)
        {
            lblErrorMessages.ForeColor = Color.Red;
            lblErrorMessages.Text = msg;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // button for when all pateints want to be displayed
        private void btnAllPatients_Click(object sender, EventArgs e)
        {
            // uses in class example of foreach loop to display pateints
            rtbText.Text = "";
            string allRecords = "";
            foreach (var wr in _pateints)
            {
                allRecords += $"{wr}\n";
            }

            rtbText.Text = allRecords;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        // named diffrently but uses the exact same method as previous one with slight moidfactions
        private void button3_Click(object sender, EventArgs e)
        {
            
            rtbText.Text = "";

            string allRecords = "";
            foreach (var wr in _pateints)
            {
                // we only want overweight trucks here:
                if (wr.age <= Patients.MaxAge)
                    allRecords += $"{wr}\n";
            }

            rtbText.Text = allRecords;
        }
        // calls the remove vowel method and also sets the input text to be eqaul to the textbox
        private void button2_Click(object sender, EventArgs e)
        {

            string inputText = txtBoxInputText.Text;
            RemoveVowels(inputText);
        }

        private void groupBoxQuestion2_Enter(object sender, EventArgs e)
        {

        }
    }
}