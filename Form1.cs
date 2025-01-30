using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _2025._01._30.dolgozat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Start();
        }
        void Start()
        {
            AutoGumi autoGumiButton = new AutoGumi("Gumi", "gumi", 20000);
            this.Controls.Add(autoGumiButton);
            Teligumi teliAutoGumiButton = new Teligumi("Téligumi", "puhagumi", 25000, "5*-os teljesítmény")
            {
                Left = autoGumiButton.Left + 100
            };
            this.Controls.Add(teliAutoGumiButton);
        }
    }
}
