using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSMS.View.Component
{
    public partial class HP_Control : UserControl
    {
        public HP_Control(string PageTitle)
        {
            InitializeComponent();

            if(PageTitle == "Unisex" )
            {
                string ImagePath = Path.Combine(@"D:\C# Projects\OSMS\Images", "unisex.png");
                Image image = Image.FromFile(ImagePath);
                pictureBox1.Image = image;
            }
            else if(PageTitle == "Man")
            {
                string ImagePath = Path.Combine(@"D:\C# Projects\OSMS\Images", "man.png");
                Image image = Image.FromFile(ImagePath);
                pictureBox1.Image = image;

            }
            else if(PageTitle == "Woman") {
                string ImagePath = Path.Combine(@"D:\C# Projects\OSMS\Images", "woman.png");
                Image image = Image.FromFile(ImagePath);
                pictureBox1.Image = image;
            }
            else
            {
                string ImagePath = Path.Combine(@"D:\C# Projects\OSMS\Images", "HomePage.png");
                Image image = Image.FromFile(ImagePath);
                pictureBox1.Image = image;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
