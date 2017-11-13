using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAsscess;
namespace Business_Logic
{
    public class XL_CHUONGTRINH : XL_BANG
    {
        public XL_CHUONGTRINH() : base("CHUONGTRINH") { }
        public XL_CHUONGTRINH(string chuoiSQL) : base("CHUONGTRINH", chuoiSQL) { }

    }
}
