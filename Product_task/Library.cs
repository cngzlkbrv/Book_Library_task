using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_task
{
    internal class Library
    {
        Book []Books=new Book[0];
        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length+1);
            Books[Books.Length - 1] = book;
        }
        public void GetBook(int id)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if(Books[i].Id == id) {
                    Console.WriteLine(Books[i].Name, Books[i].AutorName, Books[i].AutorName);
                }
            }
        }
        public void AllBooks() {
        for (int j = 0;j < Books.Length;j++) {
            Console.WriteLine($"Adi={Books[j].Name} ,Yazar={Books[j].AutorName} ,Sehife sayi={Books[j].PageCount} ,Id={Books[j].Id} , Qiymeti={Books[j].Price} ,Kodu={Books[j].Code} ");
            }
        }
    }
}
