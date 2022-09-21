namespace Properties_Assignment
{

    class Details
    {


        private int isbn;
        private string bookname;
        private string booktitle;
        private string bookauthor;
        private int quantityofbooks;
        private int bookprice;

       
        public int Isbn
        {
            get { return isbn; }//getter
            set { isbn = value; }//setter
        }
        public string BookName
        {
            get { return bookname; }//getter
            set { bookname = value; }//setter
        }
        public string BookTitle
        {
            get { return booktitle; }//getter
            set { booktitle = value; }//setter
        }
        public string BookAuthor
        {
            get { return bookauthor; }//getter
            set { bookauthor = value; }//setter
        }
        public int Quantity
        {
            get { return quantityofbooks; }//getter
            set { quantityofbooks = value; }//setter
        }
        public int Price
        {
            get { return bookprice; }//getter
            set { bookprice = value; }//setter
        }


        //public void Show()
        //{
        //    Console.WriteLine($"isbn:{isbn}" + $"Book Name:{bookname}" + $"Book Title:{booktitle}" + $"Book Author:{bookauthor}" +
        //    $"Quantity: {quantityofbooks}" + $"Price:{bookprice}");
        //}

    }
    class Bookstore
    {
        public static void Main()
        {
            Details d1 = new Details();
            Console.WriteLine("Enter ISBN,Book Name,Book Title,Book Author,Quantity ,Price");
            d1.Isbn=int.Parse(Console.ReadLine());
            d1.BookName = Console.ReadLine();
            d1.BookTitle= Console.ReadLine();
            d1.BookAuthor= Console.ReadLine();
            d1.Quantity= int.Parse(Console.ReadLine());
            d1.Price=int.Parse(Console.ReadLine());

            Console.WriteLine("ISBN:{0} Book Name:{1} BookTitle:{2} BookAuthor:{3} Quantity:{4} Price:{5}", d1.Isbn, d1.BookName, d1.BookTitle, d1.BookAuthor, d1.Quantity, d1.Price);
                }
    }
}