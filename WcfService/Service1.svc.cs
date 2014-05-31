namespace WcfService
{
    using System.ServiceModel.Activation;
    using System;

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : IService1
    {
        public string GetTitle(int isbn)
        {
            return "Romeo and Juliet";
        }

        public Book GetBook(string isbn)
        {
            return new Book()
            {
                Title = "Romeo and Juliet",
                Author = "William Shakespeare",
                Publisher = "shinchosha",
                ISBN = "4102020012"
            };
        }

        public void AddBook(Book book)
        {
            Console.WriteLine(book.Title);
        }
    }
}
