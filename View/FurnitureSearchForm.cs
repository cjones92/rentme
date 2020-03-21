using FurnitureRentals.Controller;
using FurnitureRentals.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureRentals.View
{
    public partial class FurnitureSearchForm : Form
    {
        FurnitureController furnitureController;
        public FurnitureSearchForm()
        {
            furnitureController = new FurnitureController();
            InitializeComponent();
            this.LoadSearchOptionsComboBox();
            this.LoadCategoryComboBox();
            this.LoadStyleComboBox();

        }

        private void LoadSearchOptionsComboBox()
        {
            List<string> choices = new List<string> { "Serial Number", "Category", "Style" };
            this.SearchOptionsComboBox.DataSource = choices;
        }

        private void LoadCategoryComboBox()
        {
            try
            {
                List<Category> categoryList = this.furnitureController.GetCategories();
                this.categoryComboBox.DataSource = categoryList;
                this.categoryComboBox.ValueMember = "CategoryID";
                this.categoryComboBox.DisplayMember = "CategoryDescription";

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem reaching the database. Please check the database connection.");
            }
        }

        private void LoadStyleComboBox()
        {

            try
            {
                List<Style> styleList = this.furnitureController.GetStyles();
                this.furnitureStyleComboBox.DataSource = styleList;
                this.furnitureStyleComboBox.ValueMember = "StyleID";
                this.furnitureStyleComboBox.DisplayMember = "StyleDescription";

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem reaching the database. Please check the database connection.");
            }
        }

        private void LoadFurnitureGridView()
        {
            List<Furniture> furnitureList;


            FurnitureDataGridView.AllowUserToAddRows = false;

            string searchChoice = (string)this.SearchOptionsComboBox.SelectedValue;
            if (searchChoice == "Serial Number" && this.SerialNumberTextBox.TextLength > 3)
            {

                furnitureList = this.furnitureController.GetFurnitureBySerialNumber(this.SerialNumberTextBox.Text);
                furnitureBindingSource.DataSource = furnitureList;
            }
            else if ((searchChoice == "Category") && (this.categoryComboBox.SelectedIndex > -1))
            {
                furnitureList = this.furnitureController.GetFurnitureByCategory((int.Parse(this.categoryComboBox.SelectedValue.ToString())));
                furnitureBindingSource.DataSource = furnitureList;
            }
            else if (searchChoice == "Style" && this.furnitureStyleComboBox.SelectedIndex > -1)
            {
                furnitureList = this.furnitureController.GetFurnitureByStyleID(int.Parse(this.furnitureStyleComboBox.SelectedValue.ToString()));
              furnitureBindingSource.DataSource = furnitureList;
            }



        }

        private void SearchOptionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = (string)this.SearchOptionsComboBox.SelectedValue;
            if (selectedValue == "Serial Number")
            {
                this.CategoryLabel.Visible = false;
                this.categoryComboBox.Visible = false;
                this.StyleLabel.Visible = false;
                this.furnitureStyleComboBox.Visible = false;
                this.SerialNumberLabel.Visible = true;
                this.SerialNumberTextBox.Visible = true;
            }
            else if (selectedValue == "Category")
            {
                this.StyleLabel.Visible = false;
                this.furnitureStyleComboBox.Visible = false;
                this.SerialNumberLabel.Visible = false;
                this.SerialNumberTextBox.Visible = false;
                this.CategoryLabel.Visible = true;
                this.categoryComboBox.Visible = true;

            }
            else if (selectedValue == "Style")
            {
                this.SerialNumberTextBox.Visible = false;
                this.SerialNumberLabel.Visible = false;
                this.categoryComboBox.Visible = false;
                this.CategoryLabel.Visible = false;
                this.StyleLabel.Visible = true;
                this.furnitureStyleComboBox.Visible = true;
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadFurnitureGridView();
        }

        private void furnitureStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadFurnitureGridView();
        }

        private void SerialNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            this.LoadFurnitureGridView();
        }

        private void furnitureStyleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

