using System.Text.RegularExpressions;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        private string _ProductName;
        private string _Category;
        private string _MfgDate;
        private string _ExpDate;
        private string _Description;
        private int _Quantity;
        private double _SellPrice;

        private BindingSource showProductList;

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                throw new StringFormatException("Product name cannot be empty. Please enter a valid string.");
            else return name;
        }

        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]+$"))
                throw new StringFormatException("Quantity cannot be empty. Please enter a valid integer. ");
            else return Convert.ToInt32(qty);
        }

        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                throw new StringFormatException("Selling price cannot be empty. Please enter a valid number.");
            else return Convert.ToDouble(price);
        }

        class NumberFormatException : Exception
        {
            public NumberFormatException(string message) : base(message) {
            }
        }

        class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string message) : base(message) {
            }
        }

        class StringFormatException : Exception
        {
            public StringFormatException(string message) : base(message) {
            }
        }

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = new string[]{
                "Beverages",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Dairy",
                "Frozen Goods",
                "Meat",
                "Personal Care",
                "Other"
            };

            foreach (string category in ListOfProductCategory)
            {
                cbCategory.Items.Add(category);
            }

            showProductList = new BindingSource();
        }

        private void clearFields()
        {
            txtProductName.Clear();
            txtQuantity.Clear();
            txtSellPrice.Clear();
            richTxtDescription.Clear();
            cbCategory.SelectedIndex = -1;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            bool valid = false;

            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);
                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
                _ExpDate, _SellPrice, _Quantity, _Description));
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;

                valid = true;
            }


            catch (StringFormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Invalid input, please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (CurrencyFormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Invalid input, please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (NumberFormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Invalid input, please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (valid) clearFields();
            }
        }
    }
}
