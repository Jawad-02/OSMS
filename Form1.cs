using OSMS.Models;
using OSMS.PublicClasses;
using OSMS.View.Component;
using OSMS.View.Component.Headers;
using System.Windows.Forms;

namespace OSMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AutoScroll = true;
            SetUpPage("HomePage");

            if(SessionManager.UserID == 0)
                SetUpHeader("LougedoutHeader");
            else if(SessionManager.UserID > 0 && SessionManager.Role == "Admin") 
                SetUpHeader("AdminHeader");
            else
                SetUpHeader("LogedinHeader");

        }
        public void UnCheckButtons()
        {
            HomePage.Checked = false;
            guna2Button2.Checked = false;
            guna2Button3.Checked = false;
            guna2Button4.Checked = false;
        }
        private void LoadHeroControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panelHero.Controls.Clear();
            panelHero.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void SetUpPage(string PageTitle)
        { 
            HP_Control hP = new HP_Control(PageTitle);
            LoadHeroControl(hP);

            PanelProducts.Controls.Clear();
            Products products = new Products();
            Category cat = new Category();
            List<Products> products1 = PageTitle.ToLower() == "homepage" ? products.GetAllProducts() : products.GetAllProductsByCategoryID(cat.GetCategoryIdByCategoryName(PageTitle.ToLower()));

            foreach (Products product in products1)
            {
                ProudctPage pg = new ProudctPage(product);
                PanelProducts.Controls.Add(pg);
            }
        }
        private void SetUpHeader(string Header)
        {
            UserControl header = null;  
            if (Header == "LougedoutHeader")  
                 header = new LougedoutHeader();
            if (Header == "LogedinHeader")
                header = new LogedinHeader();
            if (Header == "AdminHeader")
                header = new AdminHeader();

            header.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(header);
            header.BringToFront();

        }
        private void HomePage_Click(object sender, EventArgs e)
        {
            UnCheckButtons();
            HomePage.Checked = true;
            SetUpPage("HomePage");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UnCheckButtons();
            guna2Button2.Checked = true;
            SetUpPage("Men");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UnCheckButtons();
            guna2Button3.Checked = true;
            SetUpPage("Women");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UnCheckButtons();
            guna2Button4.Checked = true;
            SetUpPage("Unisex");
        }
    }
}
