using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class ProductViewModel
	{
        public Product Product = new();
        [ValidateNever]
        public IEnumerable<SelectListItem> CategoryList { get;set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CoverTypeList { get;set;}
    }
}
