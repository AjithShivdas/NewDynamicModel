using Autofac;
using ProcessDynamicModel.Helpers;
using ProcessDynamicModel.Helpers.Abstract;
using ProcessDynamicModel.UserModel;
using ProcessDynamicModel.UserModel.Abstract;

namespace ProcessDynamicModel.ContainerBuilders
{
    class IocContainers
    {

        public static IContainer GetIContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Branch>().As<IBranch>();
            builder.RegisterType<ProcessHelper>().As<IProcessHelper>();
            return builder.Build();
        }
    }
}
