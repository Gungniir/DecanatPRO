using DataAccessLayer;
using Model;
using Ninject.Modules;

namespace BusinessLogic;

public class SimpleConfigModule: NinjectModule
{
    public override void Load()
    {
        Bind<IRepository<Student>>().To<StudentEntityRepository>().InSingletonScope();
    }
}