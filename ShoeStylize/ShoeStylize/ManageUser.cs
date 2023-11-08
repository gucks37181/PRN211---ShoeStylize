using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace ShoeStylize
{
    public partial class ManageUser : Form
    {
        public UserRepository userRepository;

        public void clearTextBox()
        {
            txtUserID.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtFullName.Text = "";
            txtPhone.Text = "";
            txtBirthDate.Text = "";
            txtRoleID.Text = "";
            txtGender.Text = "";
        }

        public void updateGridView()
        {
            var users = userRepository.GetAll().ToList();
            if (users != null)
            {
                var listUser = users.ToList();

                dgvUser.DataSource = listUser.Select(p => new
                {
                    Id = p.UserId,
                    Email = p.Email,
                    Password = p.Password,
                    FullName = p.FullName,
                    Phone = p.PhoneNumber,
                    Birthdate = p.Birthdate,
                    RoleID = p.RoleId,
                    Gender = p.Gender,
                }).ToList();
            }
        }

        public ManageUser()
        {
            InitializeComponent();
            userRepository = new UserRepository();
            updateGridView();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvUser.Rows[e.RowIndex];
            txtUserID.Text = row.Cells[0].Value.ToString();
            txtEmail.Text = row.Cells[1].Value.ToString();
            txtPassword.Text = row.Cells[2].Value.ToString();
            txtFullName.Text = row.Cells[3].Value.ToString();
            txtPhone.Text = row.Cells[4].Value.ToString();

            
            if (DateTime.TryParse(row.Cells[5].Value.ToString(), out DateTime birthDate))
            {
                txtBirthDate.Text = birthDate.ToString("yyyy-MM-dd");
            }
            else
            {
                MessageBox.Show("Invalid post day input. Please try again.");
            }

            txtRoleID.Text = row.Cells[6].Value.ToString();
            txtGender.Text = row.Cells[7].Value.ToString();

            buttonCreate.Enabled = false;
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
            buttonCancel.Enabled = true;
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtBirthDate.Text) ||
                string.IsNullOrWhiteSpace(txtRoleID.Text) ||
                string.IsNullOrWhiteSpace(txtGender.Text))
            {
                MessageBox.Show("All fields must be filled out. Please try again.");
                return;
            }

            DateTime birthDate;
            if (DateTime.TryParse(txtBirthDate.Text, out birthDate))
            {
                if (birthDate.Year > DateTime.Now.Year)
                {
                    MessageBox.Show("Invalid birth year. Please enter a valid date.");
                    return;
                }

                var email = txtEmail.Text;
                var fullname = txtFullName.Text;
                var password = txtPassword.Text;
                var phone = txtPhone.Text;
                var roleID = txtRoleID.Text;
                var gender = txtGender.Text;

                var user = new User()
                {
                    Email = email,
                    FullName = fullname,
                    Password = password,
                    PhoneNumber = phone,
                    Birthdate = birthDate,
                    RoleId = roleID,
                    Gender = gender,
                };
                userRepository.Add(user);
                updateGridView();
                clearTextBox();
            }
            else
            {
                MessageBox.Show("Invalid birthDate input. Please enter a valid date.");
            }
        }

        private void txtBirthDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(txtUserID.Text);
            var user = userRepository.GetAll().Where(p => p.UserId == userID).FirstOrDefault();

            if (user != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    userRepository.Delete(user);
                    updateGridView();

                    buttonCreate.Enabled = true;
                    buttonUpdate.Enabled = false;
                    buttonDelete.Enabled = false;
                    buttonCancel.Enabled = false;
                    clearTextBox();
                }
            }
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtBirthDate.Text) ||
                string.IsNullOrWhiteSpace(txtRoleID.Text) ||
                string.IsNullOrWhiteSpace(txtGender.Text))
            {
                MessageBox.Show("All fields must be filled out. Please try again.");
                return;
            }

            var userID = int.Parse(txtUserID.Text);
            var user = userRepository.GetAll().Where(p => p.UserId == userID).FirstOrDefault();

            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.FullName = txtFullName.Text;
            user.PhoneNumber = txtPhone.Text;

            DateTime birthDate;
            if (DateTime.TryParse(txtBirthDate.Text, out birthDate))
            {
                if (birthDate.Year > DateTime.Now.Year)
                {
                    MessageBox.Show("Invalid birth year. Please enter a valid date.");
                    return;
                }

                user.Birthdate = birthDate;
            }
            else
            {
                MessageBox.Show("Invalid birthDate input. Please enter a valid date.");
                return;
            }

            user.RoleId = txtRoleID.Text;
            user.Gender = txtGender.Text;
            userRepository.Update(user);
            updateGridView();

            buttonCreate.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            buttonCancel.Enabled = false;
            clearTextBox();
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonCreate.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            buttonCancel.Enabled = false;
            clearTextBox();
        }
    }
}
