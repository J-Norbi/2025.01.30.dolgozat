﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _2025._01._30.dolgozat
{
    internal class Teligumi : AutoGumi
    {
        public Teligumi(string name, string material, int price, string pluszAdat):base(name, material, price)
        {
            nev = name;
            anyag = material;
            ar = price;
            ertekeles = pluszAdat;
            this.BackColor = Color.Gray;
            
        }
        public override void ClickLabel(Object s, EventArgs e)
        {
            MessageBox.Show("Gumi anyaga: " + anyag + "\nGumi ára: " + ar + "\nÉrtékelés: "+ ertekeles);
        }
        public string ertekeles { get; set; }
    }
}
