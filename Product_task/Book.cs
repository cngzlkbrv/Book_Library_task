using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_task
{
    internal class Book
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string AutorName { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }
       
        public string Code { get; set; }
            


        public Book(string name,string autorName,int pageCount,double price)
        {
            _id++;
            Id= _id;
            Name= name;
            AutorName= autorName;
            PageCount= pageCount;
            Price= price;
           
            string[]names = Name.Split(' ');
            foreach(string n in names)
            {
                Code += n[0];
            }
            Code += Id;
            Code.ToUpper();

        }
    }
    
}
