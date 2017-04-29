using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace WebApplication1.Models
{
    class Domen
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                // Create and save a new Blog 
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var blog = new Products { Name = name };
                db.Products.Add(blog);
                db.SaveChanges();

                // Display all Blogs from the database 
                var query = from b in db.Products
                            orderby b.Name
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }

    public class Products
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Excerpt { get; set; }
        public int Discount { get; set; }
        public int Amount { get; set; }
        public virtual List<Reviews> Reviews { get; set; }
        public virtual List<Branches> Branches { get; set; }
        public virtual List<Manufacturer> Manufacturer { get; set; }
        public int AverageRating { get; set; }
    }

    public class ListTheUser
    {
        public   string FullName { get; set; }
        public bool Vip { get; set; }
        public string Mail { get; set; }

        public string Phone { get; set; }
        public bool BlackList { get; set; }
    }

    public class Branches
    {
        public string DirectorName { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
    }

    public class Basket
    {
        public virtual List<Products> Products { get; set; }
        public string DeliveryMethod { get; set; }
        public string DeliveryTime { get; set; }
        public string WhereToDeliver { get; set; }
        public string TotalPrice { get; set; }
    }

    public class Reviews
    {
        public virtual List<ListTheUser> User { get; set; }
        public int Evaluation { get; set; }
        public string Comment { get; set; }
        public string Time { get; set; }
        public int Marks { get; set; }
    }

    public class Manufacturer
    {
        public string CompanyName { get; set; }
        public string ReviewsCompany { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public bool Contract { get; set; }
    }
    public class BloggingContext : DbContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<ListTheUser> ListTheUser { get; set; }
    }
}