using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mssvlab4
{
    public class MyList
    {
        private IntNode first,last;
        public IntNode First
        {
            get { return first; }
            set { first = value; }
            
        }
        public MyList()
        {
            first = null;
            last = null;

        }
        public bool IsEmpTy()
        {
            return first == null;
        }
        public void AddFirst(IntNode newNode)
        {
            if(IsEmpTy())
            {
                first = last= newNode;
            }
            else
            {
                newNode.Next= first;
                first= newNode; 
            }
        }

        public void Input()
        {

            do
            {
                Console.WriteLine("Nhap gia tri cho danh sach(nhan 0 de ket thuc):");
                int x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    return;
                }
                IntNode newnode = new IntNode(x);
                AddFirst(newnode);

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
                IntNode p=first;
                while (p != null) 
                { 
                    Console.Write(p.Data+"->");
                    p = p.Next;
                }
            }
        }
        public IntNode Search(int x)
        {
            if (IsEmpTy())
            {
                return null;
            }
            IntNode p = first;
            while (p != null)
            {
                if(p.Data==x)
                {
                    return p;
                }
                p = p.Next;
            }
            return null;

        }
        public IntNode GetMax()
        {
            if(IsEmpTy())
            {
                return null;
            }
            IntNode max = first;
            IntNode p = max.Next;
            while(p!= null) 
            {
                if(max.Data<p.Data)
                
                {
                    max = p;
                }
                p = p.Next;

            }
            return null;
        }

        public MyList GetEvenList()
        {
            MyList list= new MyList();  
            IntNode p=first;
            while (p != null)
            {
                if(p.Data%2==0)
                    
                {
                    list.AddFirst(new IntNode(p.Data));
                }
                p = p.Next;
            }
            return list;
        }
        
    }
}
