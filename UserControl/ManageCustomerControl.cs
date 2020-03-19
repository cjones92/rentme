using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.User_Controls
{
    /// <summary>
    /// Class adds a new incident to the in-memory database
    /// </summary>
    public partial class AddIncidentUserControl : UserControl
    {
        private readonly CustomerController customerController;
        private readonly ProductController productController;
        private readonly IncidentController incidentController;
        private readonly RegistrationController registrationController;

        public event EventHandler DataSaved;

        /// <summary>
        /// Constructor initializes the class level variables
        /// </summary>
        public AddIncidentUserControl()
        {
            InitializeComponent();
            this.incidentController = new IncidentController();
            this.customerController = new CustomerController();
            this.productController = new ProductController();
            this.registrationController = new RegistrationController();

            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "CustomerID";

            cbProduct.DisplayMember = "Name";
            cbProduct.ValueMember = "ProductCode";

            try
            {
                cbCustomer.DataSource = this.customerController.GetAllCustomers();
                cbCustomer.SelectedIndex = 0;
            }
            catch(Exception) 
            {
                MessageBox.Show("Unable to load customers", "Error");
            }

            try
            {
                cbProduct.DataSource = this.productController.GetAllProducts();
                cbProduct.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to load products", "Error");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbCustomer.SelectedIndex = 0;
            cbProduct.SelectedIndex = 0;
            this.txtTitle.Text = "";
            this.txtDescription.Text = "";
            this.errorMessage.Text = "";
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            this.errorMessage.Text = "";
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            this.errorMessage.Text = "";
        }

        /// <summary>
        /// Method that adds the incident to the incidents table
        /// </summary>
        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            var customerId = this.cbCustomer.SelectedValue.ToString();
            var productCode = this.cbProduct.SelectedValue.ToString();
            var title = this.txtTitle.Text;
            var description = this.txtDescription.Text;

            try
            {
                if(this.registrationController.IsRegistered(Convert.ToInt32(customerId), productCode))
                {
                    IncidentDB incident = new IncidentDB();
                    incident.CustomerID = customerId;
                    incident.ProductCode = productCode;
                    incident.Title = title;
                    incident.Description = description;
                    incidentController.Add(incident);
                    if (incident.IncidentID > 0)
                    {
                        MessageBox.Show("Incident is addedd successfully", "Success");

                        if (DataSaved != null)
                        {
                            this.DataSaved(this, e);
                        }
                    }
                }                
                else
                {
                    MessageBox.Show("There is no registration associated with the product", "Error");
                }
            }
            catch (ArgumentException ae)
            {
                this.errorMessage.ForeColor = Color.Red;
                this.errorMessage.Text = ae.Message.ToString();
            }
        }
    }
}
