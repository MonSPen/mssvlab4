using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mssvlab4
{
    public class NhanVienNode
    {
        NhanVien data;
        NhanVienNode next;

        public NhanVienNode Next { get => next; set => next = value; }
        internal NhanVien Data { get { return data; } set { data = value; }
        }


       public NhanVienNode(NhanVien nv)
        {
            data = nv;
            next = null;
        }
       
    }
}
