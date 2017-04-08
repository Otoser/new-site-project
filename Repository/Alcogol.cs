namespace Repository
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Domens;
    public class Alcogol : DbContext
    {
        // Контекст настроен для использования строки подключения "Alcogol" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Repository.Alcogol" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Alcogol" 
        // в файле конфигурации приложения.
        public Alcogol()
            : base("Alcogol")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Products> Products { get; set; }
         public virtual DbSet<Basket> Basket { get; set; }
         public virtual DbSet<Branches> Branches{ get; set; }
         public virtual DbSet<ListTheUser> ListTheUser { get; set; }
         public virtual DbSet<Manufacturer> Manufacturer { get; set; }
         public virtual DbSet<Reviwes> Reviwes { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}