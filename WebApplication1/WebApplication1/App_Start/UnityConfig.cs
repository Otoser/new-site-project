using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using System.Data.Entity;
using Repository;

namespace WebApplication1
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
        
          var container = new UnityContainer();
        
        // register all your components with the container here
        // it is NOT necessary to register your controller
        // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<DbContext, Alcogol>(new HierarchicalLifetimeManager());
            container.RegisterType<IProductRepository, ProductRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IBasketRepository, BasketRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IBranchesRepository, BranchesRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IListTheUserRepository, ListTheUserRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IManufacturerRepository, ManufacturerRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IReviwesRepository, ReviwesRepository>(new HierarchicalLifetimeManager());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}