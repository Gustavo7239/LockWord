using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LockWord.Views
{
    public partial class PasswordGeneratorMenu : Form
    {
        private bool isUpperCase = false;
        private bool isLowerCase = false;
        private bool isNumbers = false;
        private bool isCharacters = false;
        private int lenghtPassword = 0;
        private int minLenghtPassword = 0;
        private int maxLenghtPassword = 0;

        private Random random = new Random();

        public PasswordGeneratorMenu()
        {
            InitializeComponent();
        }

        // Logic to ensure that maxLenghtPassword is always greater than minLenghtPassword
        public void VerifyLogic()
        {
            if (maxLenghtPassword <= minLenghtPassword)
            {
                maxLenghtPassword = minLenghtPassword + 1;
            }
            TxtNumberBox.Text = maxLenghtPassword.ToString();
        }

        // Event handlers for toggling password options
        private void BtnMarkCapitalLetters_Click(object sender, EventArgs e)
        {
            ToggleOption(ref isUpperCase, BtnMarkCapitalLetters);
            VerifyLogic();
        }

        private void BtnMarkLowercase_Click(object sender, EventArgs e)
        {
            ToggleOption(ref isLowerCase, BtnMarkLowercase);
            VerifyLogic();
        }

        private void BtnMarkNumbers_Click(object sender, EventArgs e)
        {
            ToggleOption(ref isNumbers, BtnMarkNumbers);
            VerifyLogic();
        }

        private void BtnMarkCharacters_Click(object sender, EventArgs e)
        {
            ToggleOption(ref isCharacters, BtnMarkCharacters);
            VerifyLogic();
        }

        // Method to toggle options
        private void ToggleOption(ref bool option, IconButton button)
        {
            option = !option;
            button.IconChar = option ? FontAwesome.Sharp.IconChar.CheckSquare : FontAwesome.Sharp.IconChar.Square;
            ModMinLenghtPassword(option);
        }

        // Method to modify the minimum password length
        private void ModMinLenghtPassword(bool isPluss)
        {
            minLenghtPassword += isPluss ? 1 : -1;
            LblCharacterX.Text = minLenghtPassword.ToString();
        }

        // Event handler for modifying the maximum password length
        private void BtnModLengMax_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            if (btn.Name == "BtnPlus")
            {
                maxLenghtPassword++;
            }
            else if (btn.Name == "BtnMinus" && maxLenghtPassword > minLenghtPassword + 1)
            {
                maxLenghtPassword--;
            }
            else
            {
                maxLenghtPassword = minLenghtPassword + 1;
            }
            TxtNumberBox.Text = maxLenghtPassword.ToString();
        }

        // Event handler for validating the text entered in TxtNumberBox
        private void TxtNumberBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TxtNumberBox.Text, out int result))
            {
                maxLenghtPassword = result > minLenghtPassword + 1 ? result : minLenghtPassword + 1;
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        // Event handler for generating password
        private void BtnGeneratePassword_Click(object sender, EventArgs e)
        {
            LblPasswordShow.Text = GeneratePassword();
        }

        // Method to generate a password based on selected options
        private string GeneratePassword()
        {
            // Define possible characters for each option
            string upperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCaseChars = "abcdefghijklmnopqrstuvwxyz";
            string numberChars = "0123456789";
            string specialChars = "!@#$%^&*()_+-=[]{}|;:,.<>?";

            // List to store all selected characters
            List<char> allChars = new List<char>();

            // List to store at least one character from each selected option
            List<char> selectedChars = new List<char>();

            // Add characters based on selected options
            if (isUpperCase)
            {
                allChars.AddRange(upperCaseChars.ToCharArray());
                selectedChars.Add(upperCaseChars[random.Next(0, upperCaseChars.Length)]);
            }
            if (isLowerCase)
            {
                allChars.AddRange(lowerCaseChars.ToCharArray());
                selectedChars.Add(lowerCaseChars[random.Next(0, lowerCaseChars.Length)]);
            }
            if (isNumbers)
            {
                allChars.AddRange(numberChars.ToCharArray());
                selectedChars.Add(numberChars[random.Next(0, numberChars.Length)]);
            }
            if (isCharacters)
            {
                allChars.AddRange(specialChars.ToCharArray());
                selectedChars.Add(specialChars[random.Next(0, specialChars.Length)]);
            }

            // Validate if options have been selected
            if (allChars.Count == 0)
            {
                MessageBox.Show("Please select at least one character option.");
                return null;
            }

            StringBuilder password = new StringBuilder();

            // Add at least one character from each selected option
            foreach (char selectedChar in selectedChars)
            {
                password.Append(selectedChar);
            }

            // Generate the rest of the random password
            for (int i = selectedChars.Count; i < maxLenghtPassword; i++)
            {
                char randomChar = allChars[random.Next(0, allChars.Count)];
                password.Append(randomChar);
            }

            return password.ToString();
        }

        private void BtnCopyPassword_Click(object sender, EventArgs e)
        {
            // Verificar si hay texto en LblPasswordShow
            if (!string.IsNullOrEmpty(LblPasswordShow.Text))
            {
                // Establecer el texto de la contraseña en el portapapeles
                Clipboard.SetText(LblPasswordShow.Text);

                // Opcional: Mostrar un mensaje de confirmación
                MessageBox.Show("Password copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Opcional: Mostrar un mensaje de advertencia si no hay contraseña generada
                MessageBox.Show("No password generated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
