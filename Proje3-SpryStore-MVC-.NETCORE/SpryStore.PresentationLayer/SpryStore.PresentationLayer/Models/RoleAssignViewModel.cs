using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SpryStore.PresentationLayer.Models
{
    public class RoleAssignViewModel
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public bool RoleExist { get; set; }
    }
}
