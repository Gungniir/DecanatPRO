// See https://aka.ms/new-console-template for more information

using BusinessLogic;
using ConsoleView.Commands;
using Ninject;

IKernel ninjectKernel = new StandardKernel(new SimpleConfigModule());

Logic logic = ninjectKernel.Get<Logic>();
Kernel cosnoleKernel = new(logic);

cosnoleKernel.Run();
