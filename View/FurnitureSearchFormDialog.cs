﻿using FurnitureRentals.Controller;
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
    /// <summary>
    /// Contains logic for the Furniture Search Form
    /// </summary>
    public partial class FurnitureSearchFormDialog : Form
    {
        FurnitureController furnitureController;

        /// <summary>
        /// Controller for class
        /// </summary>
        public FurnitureSearchFormDialog()
        {
            furnitureController = new FurnitureController();
            InitializeComponent();
            this.LoadSearchOptionsComboBox();
            this.LoadCategoryDescriptionComboBox();
            this.LoadStyleComboBox();

        }

        private void LoadSearchOptionsComboBox()
        {
            List<string> choices = new List<string> {"Select Search Style:", "Serial Number", "Category", "Style" };
            this.SearchOptionsComboBox.DataSource = choices;
            
        }

        private void LoadCategoryDescriptionComboBox()
        {
            try
            {
                Category dummyCategory = new Category();
                dummyCategory.CategoryID = 0;
                dummyCategory.CategoryDescription = "Pick a category:";
                List<Category> categoryList = this.furnitureController.GetCategories();
                categoryList.Insert(0, dummyCategory);
                this.CategoryDescriptionComboBox.DataSource = categoryList;
                this.CategoryDescriptionComboBox.ValueMember = "CategoryID";
                this.CategoryDescriptionComboBox.DisplayMember = "CategoryDescription";

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
                Style dummyStyle = new Style();
                dummyStyle.StyleID = 0;
                dummyStyle.StyleDescription = "Pick a style:";
                List<Style> styleList = this.furnitureController.GetStyles();
                styleList.Insert(0, dummyStyle);
                this.StyleDescriptionComboBox.DataSource = styleList;
                this.StyleDescriptionComboBox.ValueMember = "StyleID";
                this.StyleDescriptionComboBox.DisplayMember = "StyleDescription";

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

            try
            {

                string searchChoice = (string)this.SearchOptionsComboBox.SelectedValue;
                if (searchChoice == "Serial Number" && this.SerialNumberTextBox.TextLength > 3)
                {

                    furnitureList = this.furnitureController.GetFurnitureBySerialNumber(this.SerialNumberTextBox.Text);
                    furnitureBindingSource.DataSource = furnitureList;
                    if (furnitureList.Count == 0)
                    {
                        MessageBox.Show("There are no items matching this serial number");
                    }

                }
                else if ((searchChoice == "Category") && (this.CategoryDescriptionComboBox.SelectedIndex > -1 ))
                {
                    furnitureList = this.furnitureController.GetFurnitureByCategory((int.Parse(this.CategoryDescriptionComboBox.SelectedValue.ToString())));
                    furnitureBindingSource.DataSource = furnitureList;
                    if (furnitureList.Count == 0 && this.CategoryDescriptionComboBox.SelectedIndex != 0)
                    {
                        this.CategoryDescriptionComboBox.SelectedIndex = 0;
                        MessageBox.Show("There are no items matching this category");
                    }

                }
                else if (searchChoice == "Style" && this.StyleDescriptionComboBox.SelectedIndex > -1)
                {

                    furnitureList = this.furnitureController.GetFurnitureByStyleID(int.Parse(this.StyleDescriptionComboBox.SelectedValue.ToString()));
                    furnitureBindingSource.DataSource = furnitureList;

                    if (furnitureList.Count == 0 && this.StyleDescriptionComboBox.SelectedIndex != 0)
                    {
                        this.StyleDescriptionComboBox.SelectedIndex = 0;
                        MessageBox.Show("There are no items matching this style");
                    }

                }
                else
                {

                }

            } catch (Exception ex)
            {
                MessageBox.Show("There was an issue reaching the database. Please try again later");
            }

           
        }

        private void SearchOptionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = (string)this.SearchOptionsComboBox.SelectedValue;
            
            if (selectedValue == "Serial Number")
            {
                this.CategoryLabel.Visible = false;
                this.CategoryDescriptionComboBox.Visible = false;
                this.StyleLabel.Visible = false;
                this.StyleDescriptionComboBox.Visible = false;
                this.SerialNumberLabel.Visible = true;
                this.SerialNumberTextBox.Visible = true;
            }
            else if (selectedValue == "Category")
            {
                this.StyleLabel.Visible = false;
                this.StyleDescriptionComboBox.Visible = false;
                this.SerialNumberLabel.Visible = false;
                this.SerialNumberTextBox.Visible = false;
                this.CategoryLabel.Visible = true;
                this.CategoryDescriptionComboBox.Visible = true;

            }
            else if (selectedValue == "Style")
            {
                this.SerialNumberTextBox.Visible = false;
                this.SerialNumberLabel.Visible = false;
                this.CategoryDescriptionComboBox.Visible = false;
                this.CategoryLabel.Visible = false;
                this.StyleLabel.Visible = true;
                this.StyleDescriptionComboBox.Visible = true;
            } else
            {
                this.SerialNumberTextBox.Visible = false;
                this.SerialNumberLabel.Visible = false;
                this.CategoryDescriptionComboBox.Visible = false;
                this.CategoryLabel.Visible = false;
                this.StyleLabel.Visible = false;
                this.StyleDescriptionComboBox.Visible = false;
            }
        }

        private void CategoryDescriptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadFurnitureGridView();
        }

        private void StyleDescriptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadFurnitureGridView();
        }

        private void SerialNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            this.LoadFurnitureGridView();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
        }

        private void CloseFurnitureButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
