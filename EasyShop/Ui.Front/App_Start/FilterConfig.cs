namespace Ui.Front.App_Start
{
    using Bootstrap.Extensions.StartupTasks;
    using System;
    using System.Web.Mvc;

    public class FilterConfig : IStartupTask
    {
        private GlobalFilterCollection filters;

        private FilterConfig(GlobalFilterCollection filters)
        {
            this.filters = filters;
        }

        public FilterConfig()
            : this(GlobalFilters.Filters)
        {

        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
