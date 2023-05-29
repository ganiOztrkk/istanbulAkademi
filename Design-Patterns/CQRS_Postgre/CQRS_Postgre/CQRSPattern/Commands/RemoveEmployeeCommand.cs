namespace CQRS_Postgre.CQRSPattern.Commands
{
    public class RemoveEmployeeCommand
    {
        public int Id { get; set; }

        public RemoveEmployeeCommand(int id)
        {
            Id = id;
        }
    }
}
