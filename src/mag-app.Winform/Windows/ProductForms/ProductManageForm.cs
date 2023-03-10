using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.ProductService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.Product_Forms;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class ProductManageForm : Form
    {
        private ProductService _ProductService;
        public static ProductManageForm produuctManageParent;
        public ProductManageForm()
        {
            _ProductService = new ProductService(new AppDbContext());
            InitializeComponent();
            produuctManageParent = this;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(new AppDbContext());
            addProductForm.ShowDialog();
        }

        private void ProductManageForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void AddItem(string productName)
        {
            var w = new productControl(new AppDbContext())
            {
                ProductName = productName
            };
            producFlowPanel.Controls.Add(w);
        }

        public async void LoadData()
        {
            PrimaryButton primaryButton = new PrimaryButton();
            producFlowPanel.Controls.Clear();
            producFlowPanel.Controls.Add(primaryButton);
            primaryButton.Text = "Добавить продукт";
            primaryButton.Click += (s, e) =>
            {
                AddProductForm addProductForm = new AddProductForm(new AppDbContext());
                addProductForm.ShowDialog();
            };
            var items = await _ProductService.GetAllAsync(SubCategoriesForm.subCategoryParent.Id, IdentitySingelton.GetInstance().EmployeeId);
            if (items is null)
            {
                MessageBox.Show("stores not found");
            }
            else
            {
                foreach (var item in items)
                {
                    AddItem(item.ProdutName);
                }
            }
        }
        private void producFlowPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, producFlowPanel.ClientRectangle,
            Color.DimGray, 1, ButtonBorderStyle.Solid, // left
            Color.DimGray, 1, ButtonBorderStyle.Solid, // top
            Color.White, 1, ButtonBorderStyle.Solid, // right
            Color.White, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StoreProductsForm.storeProductParent.openChildForm(new SubCategoriesForm(new AppDbContext()));
            StoreProductsForm.storeProductParent.title1.Controls.RemoveAt(2);
            StoreProductsForm.storeProductParent.title2.Controls.RemoveAt(2);
            StoreProductsForm.storeProductParent.backBtn.Show();
        }
    }
}
