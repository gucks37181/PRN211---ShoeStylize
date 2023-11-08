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
    public partial class ManageSize : Form
    {
        public SizeListRepository sizeListRepository;
        public ManageSize()
        {
            InitializeComponent();
            sizeListRepository = new SizeListRepository();
            updateGridView();
        }
        public void clearTextBox()
        {
            txtSizeID.Text = "";
            txtSIze.Text = "";
        }
        public void updateGridView()
        {
            var brand = sizeListRepository.GetAll().ToList();
            if (brand != null)
            {
                var listBrand = brand.ToList();

                dgvSIze.DataSource = listBrand.Select(p => new
                {
                    Id = p.SizeId,
                    Size = p.Size,
                }).ToList();
            }
        }
        private void ManageSize_Load(object sender, EventArgs e)
        {

        }

        private void dgvSIze_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvSIze.Rows[e.RowIndex];
            txtSizeID.Text = row.Cells[0].Value.ToString();
            txtSIze.Text = row.Cells[1].Value.ToString();

            btSizeUpdate.Enabled = true;
            btSIzeDelete.Enabled = true;
            buttonCancel.Enabled = true;
            btSizeCreate.Enabled = false;
        }

        private void btSIzeDelete_Click(object sender, EventArgs e)
        {
            int SizeID = int.Parse(txtSizeID.Text);
            var Size = sizeListRepository.GetAll().Where(p => p.SizeId == SizeID).FirstOrDefault();

            if (Size != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this size?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    sizeListRepository.Delete(Size);
                    updateGridView();

                    btSizeUpdate.Enabled = false;
                    btSIzeDelete.Enabled = false;
                    buttonCancel.Enabled = false;
                    btSizeCreate.Enabled = true;
                    clearTextBox();
                }
            }
        }

        private void btSizeCreate_Click(object sender, EventArgs e)
        {
            string txtsize = txtSIze.Text;

            if (!string.IsNullOrWhiteSpace(txtsize))
            {
                var Size = new SizeList()
                {
                    Size = txtsize,
                };
                sizeListRepository.Add(Size);
                updateGridView();
                clearTextBox();
            }
            else
            {
                MessageBox.Show("Invalid or empty size input. Please enter a valid size.");
            }
        }

        private void btSizeUpdate_Click(object sender, EventArgs e)
        {
            var sizeID = int.Parse(txtSizeID.Text);
            var size = sizeListRepository.GetAll().Where(p => p.SizeId == sizeID).FirstOrDefault();

            string txtsize = txtSIze.Text;

            if (!string.IsNullOrWhiteSpace(txtsize))
            {
                size.Size = txtsize;
                sizeListRepository.Update(size);
                updateGridView();

                btSizeUpdate.Enabled = false;
                btSIzeDelete.Enabled = false;
                buttonCancel.Enabled = false;
                btSizeCreate.Enabled = true;
                clearTextBox();
            }
            else
            {
                MessageBox.Show("Invalid or empty size input. Please enter a valid size.");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            btSizeUpdate.Enabled = false;
            btSIzeDelete.Enabled = false;
            buttonCancel.Enabled = false;
            btSizeCreate.Enabled = true;
            clearTextBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
