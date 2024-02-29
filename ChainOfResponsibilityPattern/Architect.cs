using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Architect : IHandler
    {
        private IHandler nextPersonToHandleWork;
        public void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(Architect));
            this.nextPersonToHandleWork.Handle(requirement);
        }

        public void HandOverWhenDone(IHandler handler)
        {
            this.nextPersonToHandleWork = handler;
        }
    }
}
