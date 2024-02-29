namespace ChainOfResponsibilityPattern
{
    class ProgramManager : IHandler
    {
        private IHandler nextPersonToHandleWork;
        public void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(ProgramManager));
            this.nextPersonToHandleWork.Handle(requirement);
        }

        public void HandOverWhenDone(IHandler handler)
        {
            this.nextPersonToHandleWork = handler;
        }
    }
}
