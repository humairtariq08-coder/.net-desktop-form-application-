using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set the form properties through code.
            // These can also be configured from the Properties window.
            this.Text = "Student Registration Form";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Add department options to the ComboBox.
            cmbDepartment.Items.Add("Computer Science");
            cmbDepartment.Items.Add("Software Engineering");
            cmbDepartment.Items.Add("Information Technology");

            // Select the first department by default.
            cmbDepartment.SelectedIndex = 0;
        }

        // This method runs when the SAVE button is clicked.
        private void btnSave_Click(object sender, EventArgs e)
        {
            // ---------------------------------------------------------
            // STEP 1: INPUT VALIDATION
            // ---------------------------------------------------------

            // Check whether Student Name is empty.
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show(
                    "Please enter the Student Name.",
                    "Input Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                // Put the cursor back into the Name textbox.
                txtName.Focus();

                // Stop the method here.
                return;
            }

            // Check whether Roll Number is empty.
            if (string.IsNullOrWhiteSpace(txtRollNo.Text))
            {
                MessageBox.Show(
                    "Please enter the Roll Number.",
                    "Input Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtRollNo.Focus();

                return;
            }


            // ---------------------------------------------------------
            // STEP 2: EXTRACT STUDENT INFORMATION
            // ---------------------------------------------------------

            // Get the Student Name.
            string studentName = txtName.Text.Trim();

            // Get the Roll Number.
            string rollNumber = txtRollNo.Text.Trim();

            // Get the selected Department.
            string department = cmbDepartment.Text;


            // ---------------------------------------------------------
            // STEP 3: IDENTIFY GENDER
            // ---------------------------------------------------------

            string gender = "";

            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }
            else if (rbOther.Checked)
            {
                gender = "Other";
            }
            else
            {
                gender = "Not Selected";
            }


            // ---------------------------------------------------------
            // STEP 4: COLLECT HOBBIES
            // ---------------------------------------------------------

            // List is used to store multiple selected hobbies.
            List<string> hobbies = new List<string>();

            if (chkReading.Checked)
            {
                hobbies.Add("Reading");
            }

            if (chkGaming.Checked)
            {
                hobbies.Add("Gaming");
            }

            if (chkSports.Checked)
            {
                hobbies.Add("Sports");
            }

            if (chkCoding.Checked)
            {
                hobbies.Add("Coding");
            }

            // Convert the list into a comma-separated string.
            string hobbyText;

            if (hobbies.Count > 0)
            {
                hobbyText = string.Join(", ", hobbies);
            }
            else
            {
                hobbyText = "None";
            }


            // ---------------------------------------------------------
            // STEP 5: CREATE OUTPUT MESSAGE
            // ---------------------------------------------------------

            string studentInformation =
                "STUDENT REGISTRATION DETAILS\n" +
                "----------------------------------------\n" +
                "Student Name : " + studentName + "\n" +
                "Roll Number  : " + rollNumber + "\n" +
                "Department   : " + department + "\n" +
                "Gender       : " + gender + "\n" +
                "Hobbies      : " + hobbyText;


            // ---------------------------------------------------------
            // STEP 6: DISPLAY INFORMATION
            // ---------------------------------------------------------

            MessageBox.Show(
                studentInformation,
                "Registration Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Optional:
            // ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // -------------------------------------------------------------
        // OPTIONAL METHOD: CLEAR ALL FIELDS
        // -------------------------------------------------------------

        private void ClearFields()
        {
            // Clear textboxes.
            txtName.Clear();
            txtRollNo.Clear();

            // Reset department.
            cmbDepartment.SelectedIndex = 0;

            // Uncheck gender radio buttons.
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbOther.Checked = false;

            // Uncheck hobbies.
            chkReading.Checked = false;
            chkGaming.Checked = false;
            chkSports.Checked = false;
            chkCoding.Checked = false;

            // Put cursor back into Student Name.
            txtName.Focus();
        }
    }
}