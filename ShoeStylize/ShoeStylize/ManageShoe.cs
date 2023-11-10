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

namespace ShoeStylize
{
    public partial class ManageShoe : Form
    {
        public ShoeRepository shoeRepository;
        public BrandRepository brandRepository;
        public SizeListRepository sizeListRepository;

        public ManageShoe()
        {
            InitializeComponent();
            shoeRepository = new ShoeRepository();
            updateGridView();
        }
        public void clearTextBox()
        {
            txtBrandID.Text = "";
            txtColor.Text = "";
            txtDescrip.Text = string.Empty;
            txtImage.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuanity.Text = string.Empty;
            txtShoeID.Text = string.Empty;
            txtShoeName.Text = string.Empty;
            txtSize.Text = string.Empty;
            txtSIzeID.Text = string.Empty;
        }
        public void updateGridView()
        {
            var shoe = shoeRepository.GetAll().ToList();
            if (shoe != null)
            {
                var listShoe = shoe.ToList();

                dgvShoe.DataSource = listShoe.Select(p => new
                {
                    ShoeId = p.ShoeId,
                    BrandId = p.BrandId,
                    ShoeName = p.ShoesName,
                    Description = p.Description,
                    Size = p.Size,
                    Color = p.Color,
                    Image = p.Image,
                    Quanity = p.Quantity,
                    Price = p.Price,
                    SizeID = p.SizeId,

                }).ToList();
            }
        }
        private void ManageShoe_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvshoe_doubleclick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvShoe.Rows[e.RowIndex];
            txtShoeID.Text = row.Cells[0].Value.ToString();
            txtBrandID.Text = row.Cells[1].Value.ToString();
            txtShoeName.Text = row.Cells[2].Value.ToString();
            txtDescrip.Text = row.Cells[3].Value.ToString();
            txtSize.Text = row.Cells[4].Value.ToString();
            txtColor.Text = row.Cells[5].Value.ToString();
            txtImage.Text = row.Cells[6].Value.ToString();
            txtQuanity.Text = row.Cells[7].Value.ToString();
            txtPrice.Text = row.Cells[8].Value.ToString();
            txtSIzeID.Text = row.Cells[9].Value.ToString();

            btUpdate.Enabled = true;
            btDelete.Enabled = true;
            buttonCancel.Enabled = true;
            btCreate.Enabled = false;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int ShoeID = int.Parse(txtShoeID.Text);
            var Shoe = shoeRepository.GetAll().Where(p => p.ShoeId == ShoeID).FirstOrDefault();

            if (Shoe != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this shoe?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    shoeRepository.Delete(Shoe);
                    updateGridView();

                    btCreate.Enabled = true;
                    btUpdate.Enabled = false;
                    btDelete.Enabled = false;
                    buttonCancel.Enabled = false;
                    clearTextBox();
                }
            }
        }


        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrandID.Text) || string.IsNullOrWhiteSpace(txtShoeName.Text) || string.IsNullOrWhiteSpace(txtDescrip.Text) ||
                string.IsNullOrWhiteSpace(txtSize.Text) || string.IsNullOrWhiteSpace(txtColor.Text) || string.IsNullOrWhiteSpace(txtImage.Text) ||
                string.IsNullOrWhiteSpace(txtQuanity.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtSIzeID.Text))
            {
                MessageBox.Show("All fields must be filled out. Please try again.");
                return;
            }

            var shoeID = int.Parse(txtShoeID.Text);
            var shoe = shoeRepository.GetAll().Where(p => p.ShoeId == shoeID).FirstOrDefault();

            shoe.BrandId = int.Parse(txtBrandID.Text);
            shoe.ShoesName = txtShoeName.Text;
            shoe.Description = txtDescrip.Text;
            shoe.Size = txtSize.Text;
            shoe.Color = txtColor.Text;
            shoe.Image = txtImage.Text;
            shoe.Quantity = int.Parse(txtQuanity.Text);
            shoe.Price = decimal.Parse(txtPrice.Text);
            shoe.SizeId = int.Parse(txtSIzeID.Text);

            shoeRepository.Update(shoe);
            updateGridView();

            btCreate.Enabled = true;
            btUpdate.Enabled = false;
            btDelete.Enabled = false;
            buttonCancel.Enabled = false;
            clearTextBox();
        }


        private void btCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrandID.Text) || string.IsNullOrWhiteSpace(txtShoeName.Text) || string.IsNullOrWhiteSpace(txtDescrip.Text) ||
                string.IsNullOrWhiteSpace(txtSize.Text) || string.IsNullOrWhiteSpace(txtColor.Text) || string.IsNullOrWhiteSpace(txtImage.Text) ||
                string.IsNullOrWhiteSpace(txtQuanity.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtSIzeID.Text))
            {
                MessageBox.Show("All fields must be filled out. Please try again.");
                return;
            }

            var brandID = int.Parse(txtBrandID.Text);
            var shoeName = txtShoeName.Text;
            var description = txtDescrip.Text;
            var size = txtSize.Text;
            var color = txtColor.Text;
            var image = txtImage.Text;
            var quanity = int.Parse(txtQuanity.Text);
            var price = decimal.Parse(txtPrice.Text);
            var sizeID = GetSizeIdBySize(txtSize.Text);

            var shoe = new Shoe()
            {
                BrandId = brandID,
                ShoesName = shoeName,
                Description = description,
                Size = size,
                Color = color,
                Image = image,
                Quantity = quanity,
                Price = price,
                SizeId = sizeID,
            };

            shoeRepository.Add(shoe);
            updateGridView();
            clearTextBox();
        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            btCreate.Enabled = true;
            btUpdate.Enabled = false;
            btDelete.Enabled = false;
            buttonCancel.Enabled = false;
            clearTextBox();
        }
        // Add this method to your ManageShoe form
        private int? GetSizeIdBySize(string size)
        {
            var shoe = shoeRepository.GetAll().FirstOrDefault(p => p.Size.Equals(size, StringComparison.OrdinalIgnoreCase));
            if (shoe != null)
            {
                return shoe.SizeId;
            }
            return null; // Size not found
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
