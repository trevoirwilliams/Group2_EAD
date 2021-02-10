using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWinforms_Group2
{
    public partial class Form1 : Form
    {
        private readonly PersonalInformation_Group2Entities _db;
        public Form1()
        {
            InitializeComponent();
            _db = new PersonalInformation_Group2Entities();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Exception Handling - This is done through a try..catch statement which will try to do 
            // something and then catch any errors that might arise, that would crash our program. 
            try
            {
                var firstName = tbFirstName.Text;
                var lastName = tbLastName.Text;
                var dob = dtDateOfBirth.Value;
                var school_id = Convert.ToInt32(cbSchools.SelectedValue);
                var weight = Convert.ToInt32(tbWeight.Text);

                // Validate Form Data and display alerts if invalid
                // Is the name fields are empty or is the date today 
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName)
                    || dob > DateTime.Now )
                {
                    /*PRINT ERROR MESSAGE(S)*/
                    MessageBox.Show("PLEASE FILL OUT THIS FORM PROPERLY");
                }
                else
                {
                    // Save Data in database
                    _db.PersonRecords.Add(new PersonRecord {
                        DateOfBirth = dob,
                        FirstName = firstName,
                        LastName = lastName,
                        Weight = weight,
                        School_Id = school_id
                    });

                    _db.SaveChanges();

                    // Display Thank you message

                    MessageBox.Show($"You just entered data for {firstName} {lastName}");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something Fatal has occurred. Please try again later.");
                //////throw;
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = "";
            dtDateOfBirth.Value = DateTime.Now.AddDays(-1);
        }

        /*
           1. Need Do something when the form loads - X
           2. Need to query database for list of schools
           3. Need to use list of schools to populate dropdownlist
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            // Select * from Schools
            var schools = _db.Schools.ToList();
            cbSchools.DataSource = schools;
            cbSchools.DisplayMember = "Name";
            cbSchools.ValueMember = "Id";
        }


    }
}
