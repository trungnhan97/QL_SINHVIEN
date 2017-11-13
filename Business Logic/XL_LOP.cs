using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAsscess;

namespace Business_Logic
{
    public class XL_LOP : XL_BANG
    {
        public XL_LOP() : base("LOP") { }
        public XL_LOP(string chuoiSQL) : base("LOP", chuoiSQL) { }

    }
}
