namespace Ui.Front.App_Start
{
    using Bootstrap.SimpleInjector;
    using SimpleInjector;
    using SimpleInjector.Integration.Web.Mvc;
    using System.Reflection;
    using System.Web.Mvc;

    public class SimpleInjectorRegistration : ISimpleInjectorRegistration
    {
        public void Register(Container container)
        {
            // Registration of concrete classes

            // Needed for registration of controllers
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.RegisterMvcAttributeFilterProvider();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}