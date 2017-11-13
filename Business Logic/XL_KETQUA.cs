using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAsscess;

namespace Business_Logic
{
    public class XL_KETQUA : XL_BANG
    {
        public XL_KETQUA() : base("KETQUA") { }
        public XL_KETQUA(string chuoiSQL) : base("KETQUA", chuoiSQL) { }

    } 
}
