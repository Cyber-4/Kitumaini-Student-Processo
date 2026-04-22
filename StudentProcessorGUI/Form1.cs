namespace StudentProcessorGUI
{
    public partial class Form1 : Form
    {// Global/Class-level scope variable
        string companyName = "Kitumaini Digital Solutions";

        public Form1()
        {
            InitializeComponent();
            // Sets the title of the window
            this.Text = $"{companyName} - Readiness System";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // We use a try-catch block as a safety net. If the user leaves a box blank 
            // and clicks calculate, the program won't crash!
            try
            {
                // 1. Variables & Getting Input from TextBoxes
                string studentName = txtName.Text;

                // Type casting from string (TextBox text) to int/double
                int studentAge = Convert.ToInt32(txtAge.Text);
                bool hasLaptop = chkLaptop.Checked; // Checkboxes are already boolean!
                int studyHours = Convert.ToInt32(txtHours.Text);

                double mod1 = Convert.ToDouble(txtMod1.Text);
                double mod2 = Convert.ToDouble(txtMod2.Text);
                double mod3 = Convert.ToDouble(txtMod3.Text);

                // 2. Expressions & Arithmetic Operators
                double averagePercentage = (mod1 + mod2 + mod3) / 3.0;

                // 3. Method Call
                int readinessScore = CalculateReadiness(studentAge, averagePercentage, hasLaptop, studyHours);

                // 4. Output Formatting to the ListBox
                lstOutput.Items.Clear(); // Clears old results if they click it twice
                lstOutput.Items.Add($"--- Profile Created for {studentName} ---");
                lstOutput.Items.Add($"Calculated Average: {Math.Round(averagePercentage, 2)}%");
                lstOutput.Items.Add($"Readiness Indicator: {readinessScore}/100");
            }
            catch (Exception)
            {
                // If they type letters instead of numbers, show an error popup
                MessageBox.Show("Please ensure all fields are filled in correctly with numbers where required.", "Input Error");
            }
        }

        // The exact same method we used in the console app!
        private int CalculateReadiness(int age, double average, bool laptop, int hours)
        {
            int baseScore = 20;

            if (age >= 18) { baseScore += 10; }

            if (average >= 75.0) { baseScore += 30; }
            else if (average >= 50.0) { baseScore += 15; }

            if (laptop) { baseScore += 20; }

            if (hours >= 20) { baseScore += 20; }
            else if (hours >= 10) { baseScore += 10; }

            return baseScore;
        }
    }
}
