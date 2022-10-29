using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleView.Commands
{
    internal interface ICommand
    {
        public string Command { get; init; }
        public string Description { get; init; }

        public void Execute();
    }
}
