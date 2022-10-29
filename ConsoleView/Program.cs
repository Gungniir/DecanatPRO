// See https://aka.ms/new-console-template for more information

using BusinessLogic;
using ConsoleView.Commands;

Logic logic = new();
Kernel kernel = new(logic);

kernel.Run();
