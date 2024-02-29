using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    interface IHandler
    {
        void Handle(Requirement requirement);
        void HandOverWhenDone(IHandler handler);
    }
}
