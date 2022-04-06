using System;

struct Books_Details

{
   public int bookid;
   public string title;
   public int price;
   public enum  book_type{Magazine, Novel, ReferenceBook, Miscellaneous}

   public void accept_details(int bi, string t, int p, book_type bt)
   {
       bookid = bi;
       title = t;
       price = p;
       book_type = bt;
   }

   public void display_details()
   {
        Console.WriteLine("BookID : {0}", bookid);
        Console.WriteLine("Title : {0}", title);
        Console.WriteLine("Price : {0}", price);
        Console.WriteLine("Book Type :{0}", book_type);
   }
};

public class book_types
{
    static void main()
    {
        Books_Details Book1 = new Books_Details();

        Books_Details Book2 = new Books_Details();   

        Book1.accept_details(12345,"Let US C", 500, Books_Details.book_type.ReferenceBook);

        Book2.accept_details(995345,"Emma", 500, Books_Details.book_type.Novel);

        Book1.display_details();

        Book2.display_details(); 



    }
}

