using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025._01._30.dolgozat
{
    internal class AutoGumi: UserControl, Ialkatresz
    {
        public AutoGumi(string name, string material, int price) 
        {
            InitializeComponent();
            nev = name;
            anyag = material;
            ar = price;
            label1.Text = nev;
            this.BackColor = Color.LightGray;
            label1.Click += ClickLabel;

        }
        public virtual void ClickLabel(Object s, EventArgs e)
        {
            MessageBox.Show("Gumi anyaga: " + anyag + "\nGumi ára: " + ar);
        }
        private Label label1;

        public string nev { get; set; }
        public string anyag { get; set; }
        public int ar { get; set; }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutoGumi
            // 
            this.Controls.Add(this.label1);
            this.Name = "AutoGumi";
            this.Size = new System.Drawing.Size(58, 42);
            this.ResumeLayout(false);

        }
    }
     
}
