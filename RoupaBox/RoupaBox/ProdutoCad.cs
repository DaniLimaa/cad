﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RoupaBox
{
    internal class ProdutoCad
    {
        public ProdutoCad(string pro)
        {
            descPro = pro;
        }
        public string descPro { get; set; }
        public string catPro { get; set; }
        public string marcaPro { get; set; }
        public string tamPro { get; set; }
        public string corPro { get; set; }
        public double valPro {  get; set; }
        public double pesoPro {  get; set; }
    }
}
