namespace MementoPattern
{
    public class Student
    {
        public String Status { get; set; }
        private Memento memento;

        public Student()
        {
            this.Status = "Pending Approval";
            this.memento = new Memento(this.Status);
        }

        public void StartAdmissionProcess()
        {
            this.Status = "Admitted";
        }
        public void Revert()
        {
            this.Status = this.memento.status;
        }
    }

    public class Memento
    {
        public readonly string status;

        // public Memento(DateTime time)  // for reverting to status in a specific time that the program was.
        public Memento(String status)
        {
            this.status = status;

        }
    }
}
