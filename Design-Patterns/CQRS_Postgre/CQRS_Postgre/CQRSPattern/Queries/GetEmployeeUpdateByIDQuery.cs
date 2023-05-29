namespace CQRS_Postgre.CQRSPattern.Queries
{
    public class GetEmployeeUpdateByIDQuery
    {
        public int Id { get; set; }

        public GetEmployeeUpdateByIDQuery(int id)
        {
            Id = id;
        }
    }
}
