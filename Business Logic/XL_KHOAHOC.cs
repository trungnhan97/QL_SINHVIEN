using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAsscess;

namespace Business_Logic
{
    public class XL_KHOAHOC : XL_BANG
    {
        public XL_KHOAHOC() : base("KHOAHOC") { }
        public XL_KHOAHOC(string chuoiSQL) : base("KHOAHOC", chuoiSQL) { }

    }
}
