namespace CQRS_Postgre.CQRSPattern.Queries
{
    public class GetEmployeeByIDQuery
    {
        public int Id { get; set; }

        public GetEmployeeByIDQuery(int id)
        {
            Id = id;
        }
    }
}
