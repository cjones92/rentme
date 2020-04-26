using FurnitureRentals.Controller;
using FurnitureRentals.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FurnitureRentals.View
{
    /// <summary>
    /// Contains logic for the Furniture Search Form
    /// </summary>
    public partial class FurnitureSearchFormDialog : Form
    {
        FurnitureController furnitureController;
        List<Furniture> furnitureList;
        List<Furniture> currentFurnitureList;

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
            this.furnitureList = new List<Furniture>();
            this.currentFurnitureList = new List<Furniture>();

            this.FurnitureDataGridView.AllowUserToAddRows = false;
            this.FurnitureDataGridView.RowHeadersVisible = false;
            this.FurnitureDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            this.FurnitureDataGridView.AutoResizeColumns();
            this.FurnitureDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.FurnitureDataGridView.AutoResizeRows();
            this.FurnitureDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.FurnitureDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadSearchOptionsComboBox()
        {
            List<string> choices = new List<string> { "Select Search Style:", "Serial Number", "Category", "Style" };
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
            catch (Exception)
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
            catch (Exception)
            {
                MessageBox.Show("There was a problem reaching the database. Please check the database connection.");
            }
        }

        private void LoadFurnitureGridView()
        {
            try
            {

                FurnitureDataGridView.AllowUserToAddRows = false;
                FurnitureDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
                else if ((searchChoice == "Category") && (this.CategoryDescriptionComboBox.SelectedIndex > -1))
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
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem reaching the database. Please check the database connection.");
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
            }
            else
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

        private bool CheckListValues(int furnitureID, List<Furniture> furnitureList)
        {
            foreach (Furniture furniture in furnitureList)
            {
                if (furniture.FurnitureID == furnitureID)
                {
                    return true;
                }
            }
            return false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {


            if (this.GetSelectedFurniture().Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }

        }

        /// <summary>
        /// Sets current furniture list
        /// </summary>
        /// <param name="mainformFurnitureList">furniture list</param>
        public void SetCurrentFurnitureList(List<Furniture> mainformFurnitureList)
        {
            this.currentFurnitureList = mainformFurnitureList;

        }

        /// <summary>
        /// gets a furniture list
        /// </summary>
        /// <returns>furniture list</returns>
        public List<Furniture> GetCurrentFurnitureList()
        {
            return this.currentFurnitureList;
        }

        private bool DoesListIncludeFurniture(int furnitureID, List<Furniture> furnitureList)
        {
            foreach (Furniture furniture in furnitureList)
            {
                if (furniture.FurnitureID == furnitureID)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CompareFurnitureLists(List<Furniture> firstFurnitureList, List<Furniture> secondFurnitureList)
        {
            if (firstFurnitureList.Count >= secondFurnitureList.Count)
            {
                for (int index = 0; index < secondFurnitureList.Count; index++)
                {
                    if (this.DoesListIncludeFurniture(secondFurnitureList[index].FurnitureID, firstFurnitureList))
                    {
                        return true;

                    }
                }


            }
            else
            {
                for (int index = 0; index < firstFurnitureList.Count; index++)
                    if (this.DoesListIncludeFurniture(firstFurnitureList[index].FurnitureID, secondFurnitureList))
                    {
                        return true;

                    }
            }
            return false;
        }


        private void CloseFurnitureButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        /// <summary>
        /// This method returns the furniture chosen to be added to the cart.
        /// </summary>
        /// <returns></returns>
        public List<Furniture> GetSelectedFurniture()
        {
            List<Furniture> furnitureWithQuantities = new List<Furniture>();
            List<Furniture> selectedfurnitureList = new List<Furniture>();
            foreach (DataGridViewRow row in FurnitureDataGridView.Rows)
            {
                if (row.Cells[5].Value != null)
                {
                    row.Selected = true;
                    furnitureWithQuantities.Add((Furniture)row.DataBoundItem);
                }
                else
                {
                    row.Selected = false;
                }
            }

            if (this.FurnitureDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one row");
            }
            else if (CompareFurnitureLists(furnitureWithQuantities, this.GetCurrentFurnitureList()))
            {
                MessageBox.Show("List can not have same furniture item twice");
            }
            else
            {
                foreach (DataGridViewRow row in this.FurnitureDataGridView.SelectedRows)
                {
                    if (row.Cells[5].Value == null)
                    {
                        MessageBox.Show("Please enter a value for quantity wanted in row " + (row.Index + 1));
                    }
                    else
                    {
                        string serialNumber = row.Cells[0].Value.ToString();
                        Furniture selectedFurniture = this.furnitureController.GetFurnitureBySerialNumber(serialNumber)[0];
                        selectedFurniture.QuantityOrdered = int.Parse(row.Cells[5].Value.ToString());

                        decimal rentalRate = this.furnitureList[row.Index].DailyRentalRate;
                        selectedFurniture.TotalRentalCost = selectedFurniture.QuantityOrdered * rentalRate;
                        selectedfurnitureList.Add(selectedFurniture);
                    }
                }
            }

            return selectedfurnitureList;

        }


        private void FurnitureDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int i;
            int quantityToBeOrdered = 0;
            int quantityAvailable = 0;
            if (FurnitureDataGridView.SelectedRows.Count > 0 && FurnitureDataGridView.Rows[FurnitureDataGridView.CurrentCell.RowIndex].Cells[5].Value != null && int.TryParse(Convert.ToString(e.FormattedValue), out i))
            {
                quantityToBeOrdered = int.Parse(FurnitureDataGridView.Rows[FurnitureDataGridView.CurrentCell.RowIndex].Cells[5].Value.ToString());
                FurnitureDataGridView.Rows[FurnitureDataGridView.CurrentCell.RowIndex].Selected = true;
            }

            if ((int.TryParse(Convert.ToString(e.FormattedValue), out i)) && (!string.IsNullOrEmpty(e.FormattedValue.ToString())))
            {
                quantityAvailable = int.Parse(FurnitureDataGridView.Rows[FurnitureDataGridView.CurrentCell.RowIndex].Cells[4].Value.ToString());
            }

            if (e.ColumnIndex == 5)
            {


                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {

                }

                else if (!int.TryParse(Convert.ToString(e.FormattedValue), out i) || int.Parse(Convert.ToString(e.FormattedValue)) <= 0)
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter an integer value greater than 0");
                }
                else if (quantityToBeOrdered > quantityAvailable)
                {
                    e.Cancel = true;
                    MessageBox.Show("You cannot order more than the amount available.");
                }
                else
                {

                }
            }
        }

        private void FurnitureDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (FurnitureDataGridView.IsCurrentCellDirty)
            {
                FurnitureDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);


            }
        }
    }
}

