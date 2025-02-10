using Microsoft.AspNetCore.Mvc.Rendering;

namespace DropDrownList.Models
{
    public class user
    {
        public string Gender { get; set; }
        public List<SelectListItem> GenderOptions { get; set; } = new();

    }
}
