using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class DevOpsEngineer : IHandler
    {
        public void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(DevOpsEngineer));
        }

        public void HandOverWhenDone(IHandler handler)
        {
            throw new NotImplementedException();
        }
    }
}
