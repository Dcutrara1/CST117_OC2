using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Daniel Cutrara
// Course: CST-117
// Date: 07/08/2018
// Instructor:  Prof. Smithers
// This is my own work

namespace Programming_Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void displayMilitaryButton_Click(object sender, EventArgs e)
        {
            // Variables
            string branch;         // To hold the Military Branch

            if (militaryBranchListBox.SelectedIndex != -1)
            {
                // Get the selected Branch.
                branch = militaryBranchListBox.SelectedItem.ToString();

                //Determine the branch.
                switch (branch)
                {
                    case "Army":
                        ouputBranchLabel.Text = "Army";
                        branchPictureBox.Image =
                            Programming_Assignment_2.Properties.Resources.Army;
                        break;
                    case "Navy":
                        ouputBranchLabel.Text = "Navy";
                        branchPictureBox.Image =
                            Programming_Assignment_2.Properties.Resources.Navy;
                        break;
                    case "Air Force":
                        ouputBranchLabel.Text = "Air Force";
                        branchPictureBox.Image =
                            Programming_Assignment_2.Properties.Resources.Air_Force;
                        break;
                    case "Marines":
                        ouputBranchLabel.Text = "Marines";
                        branchPictureBox.Image =
                            Programming_Assignment_2.Properties.Resources.download;
                        break;
                    case "Coast Guard":
                        ouputBranchLabel.Text = "Coast Guard";
                        branchPictureBox.Image =
                            Programming_Assignment_2.Properties.Resources.coastguard;
                        break;
                }
            }
            else
            {
                // No Branch selected.
                MessageBox.Show("Enter your Military Branch.");
            }

            // Select your Military Status
            if (activeDutyRadioButton.Checked)
            {
                militaryStatusLabel.Text = "Active Duty";
            }
            else if (reservistRadioButton.Checked)
            {
                militaryStatusLabel.Text = "Reserves";
            }
            else if (veteranRadioButton.Checked)
            {
                militaryStatusLabel.Text = "Veteran";
            }
            else if (retiredRadioButton.Checked)
            {
                militaryStatusLabel.Text = "Retired";
            }
            else
            {
                // No Military Status Selected.
                MessageBox.Show("Enter your Military Status");
            }

            // Select the information you want displayed
            if (nameCheckBox.Checked)
            {
                displayNameLabel.Text = nameTextBox.Text;
            }
            if (yearsServedCheckBox.Checked)
            {
                displayMilitaryDatesLabel.Text = enteredTextBox.Text +
                     " to " + leftTextBox.Text;
            }
            if (rankCheckBox.Checked)
            {
                displayRankLabel.Text = rankTextBox.Text;
            }
        }       
        
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the form.
            militaryBranchListBox.SelectedIndex = -1;
            activeDutyRadioButton.Checked = false;
            reservistRadioButton.Checked = false;
            veteranRadioButton.Checked = false;
            retiredRadioButton.Checked = false;
            nameCheckBox.Checked = false;
            yearsServedCheckBox.Checked = false;
            rankCheckBox.Checked = false;
            nameTextBox.Clear();
            enteredTextBox.Clear();
            leftTextBox.Clear();
            rankTextBox.Clear();
            displayRankLabel.Text = "";
            displayNameLabel.Text = "";
            displayMilitaryDatesLabel.Text = "";
            militaryStatusLabel.Text = "";
            ouputBranchLabel.Text = "";
            branchPictureBox.Image =
                Programming_Assignment_2.Properties.Resources._5_branches;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close this form.
            this.Close();
        }
    }
}
     