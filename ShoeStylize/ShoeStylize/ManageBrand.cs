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
    public partial class ManageBrand : Form
    {
        public BrandRepository brandRepository;
        public ManageBrand()
        {
            InitializeComponent();
            brandRepository = new BrandRepository();
            updateGridView();
        }
        public void clearTextBox()
        {
            txtBrandId.Text = "";
            txtBrandName.Text = "";
        }

        public void updateGridView()
        {
            var brand = brandRepository.GetAll().ToList();
            if (brand != null)
            {
                var listBrand = brand.ToList();

                dgvBrand.DataSource = listBrand.Select(p => new
                {
                    Id = p.BrandId,
                    Name = p.BrandName,
                }).ToList();
            }
        }

        private void dgvBrand_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvBrand.Rows[e.RowIndex];
            txtBrandId.Text = row.Cells[0].Value.ToString();
            txtBrandName.Text = row.Cells[1].Value.ToString();

            btBrUpdate.Enabled = true;
            btBrDelete.Enabled = true;
            btBrCreate.Enabled = false;
            buttonCancel.Enabled = true;
        }

        private void btBrDelete_Click(object sender, EventArgs e)
        {
            int BrandID = int.Parse(txtBrandId.Text);
            var BrandName = brandRepository.GetAll().Where(p => p.BrandId == BrandID).FirstOrDefault();

            if (BrandName != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this brand?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    brandRepository.Delete(BrandName);
                    updateGridView();

                    btBrCreate.Enabled = true;
                    btBrDelete.Enabled = false;
                    btBrUpdate.Enabled = false;
                    buttonCancel.Enabled = false;
                    clearTextBox();
                }
            }
        }


        private void btBrCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrandName.Text))
            {
                MessageBox.Show("Brand Name must be filled out. Please try again.");
                return;
            }

            var brandName = txtBrandName.Text;
            var brand = new Brand()
            {
                BrandName = brandName,
            };
            brandRepository.Add(brand);
            updateGridView();
            clearTextBox();
        }


        private void btBrUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrandName.Text))
            {
                MessageBox.Show("Brand Name must be filled out. Please try again.");
                return;
            }

            var brandID = int.Parse(txtBrandId.Text);
            var brand = brandRepository.GetAll().Where(p => p.BrandId == brandID).FirstOrDefault();

            brand.BrandName = txtBrandName.Text;
            brandRepository.Update(brand);
            updateGridView();

            btBrCreate.Enabled = true;
            btBrDelete.Enabled = false;
            btBrUpdate.Enabled = false;
            buttonCancel.Enabled = false;
            clearTextBox();
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            btBrCreate.Enabled = true;
            btBrDelete.Enabled = false;
            btBrUpdate.Enabled = false;
            buttonCancel.Enabled = false;
            clearTextBox();
        }
    }
}
