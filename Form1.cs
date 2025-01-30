using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            AutoGumi autoGumiButton = new AutoGumi();
            this.Controls.Add(autoGumiButton);
            Teligumi teliAutoGumiButton = new Teligumi() {Left = autoGumiButton.Left + 100};
            this.Controls.Add(teliAutoGumiButton);
        }
    }
}
