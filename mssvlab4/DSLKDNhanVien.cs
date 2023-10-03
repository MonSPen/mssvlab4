using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mssvlab4
{
    public class DSLKDNhanVien
    {
        private NhanVienNode first, last;
        public NhanVienNode First { get { return first; } set { first = value; } }
        public DSLKDNhanVien()
        {

        }
        public bool IsEmpTy()
        {
            return first == null;
        }
        public void AddFirst(NhanVienNode newNode)
        {
            if (IsEmpTy())
            {
                first = last = newNode;
            }
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }
        public void Input()
        {
            do
            {
                Console.Write("Nhap so khac 0 de nhap thong tin NV:");
                int x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    NhanVien nv = new NhanVien();
                    nv.Nhap();
                    NhanVienNode newNode = new NhanVienNode(nv);
                    AddFirst(newNode);
                } 


            } while (true);
        }
    public void ShowList()
        {
            if(IsEmpTy())
            {
                Console.WriteLine("DS rong");
            }
            else
            {
                NhanVienNode p = first;
                Console.WriteLine("Danh sach NV:");
                while(p != null)
                {
                    p.Data.Xuat();
                    p=p.Next;
                }
            }
        }
   }
}
