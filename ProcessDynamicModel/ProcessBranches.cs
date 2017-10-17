using Autofac;
using ProcessDynamicModel.ContainerBuilders;
using ProcessDynamicModel.Helpers;
using ProcessDynamicModel.Helpers.Abstract;

namespace ProcessDynamicModel
{
    class ProcessBranches
    {

        static void Main(string[] args)
        {
            var container = IocContainers.GetIContainer();
            var scope = container.BeginLifetimeScope();
            //var helper = scope.Resolve<IProcessHelper>();
            ProcessHelper helper = new ProcessHelper();
            helper.ContainerProcess();
        }


    }
}
