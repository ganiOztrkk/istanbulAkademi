using Microsoft.AspNetCore.Identity;

namespace ObserverPattern.DAL
{
    public class AppRole : IdentityRole<int> // bir yerde int yazarsak diğer yerlerde de yazmamız gerek çünkü uyuşmaması ihtimali var
    {
    }
}
