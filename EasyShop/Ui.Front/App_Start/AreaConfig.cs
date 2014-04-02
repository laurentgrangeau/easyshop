namespace Ui.Front.App_Start
{
    using Bootstrap.Extensions.StartupTasks;
    using System;
    using System.Web.Mvc;

    public class AreaConfig : IStartupTask
    {
        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            AreaRegistration.RegisterAllAreas();
        }
    }
}