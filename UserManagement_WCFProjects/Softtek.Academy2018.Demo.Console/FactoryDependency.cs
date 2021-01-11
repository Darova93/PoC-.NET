using Ninject;
using Softtek.Academy2018.Demo.Business.Contracts;
using Softtek.Academy2018.Demo.Business.Implementation;
using Softtek.Academy2018.Demo.WCF;

namespace Softtek.Academy2018.Demo.Console
{
    public static class FactoryDependency
    {
        public static IKernel GetKernel()
        {
            StandardKernel kernel = new StandardKernel();

            //Bindings
            kernel.Bind<IUserManagementService>().To<UserManagementService>();
            //kernel.Bind<IUserRepository>().To<UserFakeRepository>();
            kernel.Bind<IUserService>().To<UserService>();

            kernel.Bind<IProjectManagementService>().To<ProjectManagementService>();
            //kernel.Bind<IProjectRepository>().To<ProjectFakeRepository>();
            kernel.Bind<IProjectService>().To<ProjectService>();

            return kernel;
        }
    }

}
