using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using ORM_EFcore.Models;

namespace ORM_EFcore.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}