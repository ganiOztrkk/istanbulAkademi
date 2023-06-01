namespace AkademiPlusSignalRApi.DAL
{
    public class User
    {
        // bir kullanıcı birden fazla masada yer alamaz. online okey oyunu gibi düşünülebilir. bir user sadece bir masaya oturabilir.

        public int UserID { get; set; }
        public string UserName { get; set; }
        public Room Room { get; set; }
    }
}
