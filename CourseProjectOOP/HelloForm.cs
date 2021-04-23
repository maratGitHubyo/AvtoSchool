using System.Drawing;
using System.Windows.Forms;

namespace CourseProjectOOP
{
    internal class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelloForm));
            this.SuspendLayout();
            // 
            // HelloForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(989, 620);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelloForm";
            this.ResumeLayout(false);

        }


    }

    
}