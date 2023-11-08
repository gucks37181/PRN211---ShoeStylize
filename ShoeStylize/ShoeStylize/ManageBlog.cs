using Data;
using Data.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeStylize
{
    public partial class ManageBlog : Form
    {
        public BlogPostRepository blogPostRepository;
        public ManageBlog()
        {
            InitializeComponent();
            blogPostRepository = new BlogPostRepository();
            updateGridView();
        }

        public void clearTextBox()
        {
            txtPostID.Text = "";
            txtUserID.Text = "";
            txtTitle.Text = "";
            txtContent.Text = "";
            txtDate.Text = "";
        }

        public void updateGridView()
        {
            var blogs = blogPostRepository.GetAll().ToList();
            if (blogs != null)
            {
                var listBlog = blogs.ToList();
                dgvBlog.DataSource = listBlog.Select(p => new
                {
                    Id = p.PostId,
                    AuthorID = p.UserId,
                    Title = p.Title,
                    Content = p.Content,
                    PostDate = p.PostDay
                }).ToList();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ManageBlog_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvBlog.Rows[e.RowIndex];
            txtPostID.Text = row.Cells[0].Value.ToString();
            txtUserID.Text = row.Cells[1].Value.ToString();
            txtTitle.Text = row.Cells[2].Value.ToString();
            txtContent.Text = row.Cells[3].Value.ToString();

            if (row.Cells[4].Value is DateTime postDate)
            {
                txtDate.Text = postDate.ToString("dd-MM-yyyy");
            }
            else
            {
                MessageBox.Show("Invalid post day input. Please try again.");
            }

            buttonCreate.Enabled = false;
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
            btCancel.Enabled = true;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text) || string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtContent.Text) || string.IsNullOrWhiteSpace(txtDate.Text))
            {
                MessageBox.Show("All fields must be filled out. Please try again.");
                return;
            }

            int userID;
            if (int.TryParse(txtUserID.Text, out userID))
            {
                DateTime postDate;
                if (DateTime.TryParse(txtDate.Text, out postDate))
                {
                    if (postDate.Year > DateTime.Now.Year)
                    {
                        MessageBox.Show("Invalid post year. Please enter a valid date.");
                        return;
                    }

                    var blog = new BlogPost()
                    {
                        UserId = userID,
                        Title = txtTitle.Text,
                        Content = txtContent.Text,
                        PostDay = postDate,
                    };
                    blogPostRepository.Add(blog);
                    updateGridView();
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("Invalid post day input. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Invalid userID input. Please try again.");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text) || string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtContent.Text) || string.IsNullOrWhiteSpace(txtDate.Text))
            {
                MessageBox.Show("All fields must be filled out. Please try again.");
                return;
            }

            int postID = int.Parse(txtPostID.Text);
            var blog = blogPostRepository.GetAll().Where(p => p.PostId == postID).FirstOrDefault();

            if (int.TryParse(txtUserID.Text, out int userID))
            {
                blog.UserId = userID;
            }
            else
            {
                MessageBox.Show("Invalid userID input. Please try again.");
                return;
            }

            blog.Title = txtTitle.Text;
            blog.Content = txtContent.Text;

            if (DateTime.TryParse(txtDate.Text, out DateTime postDate))
            {
                if (postDate.Year > DateTime.Now.Year)
                {
                    MessageBox.Show("Invalid post year. Please enter a valid date.");
                    return;
                }

                blog.PostDay = postDate;
            }
            else
            {
                MessageBox.Show("Invalid post day input. Please try again.");
                return;
            }

            blogPostRepository.Update(blog);
            updateGridView();

            buttonCreate.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            btCancel.Enabled = false;
            clearTextBox();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int postID = int.Parse(txtPostID.Text);
            var blog = blogPostRepository.GetAll().Where(p => p.PostId == postID).FirstOrDefault();

            if (blog != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this blog?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    blogPostRepository.Delete(blog);
                    updateGridView();

                    buttonCreate.Enabled = true;
                    buttonUpdate.Enabled = false;
                    buttonDelete.Enabled = false;
                    btCancel.Enabled = false;
                    clearTextBox();
                }
            }
        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            buttonCreate.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            btCancel.Enabled = false;
            clearTextBox();
        }
    }
}