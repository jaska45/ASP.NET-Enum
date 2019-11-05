using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEnum.Models;

namespace RazorEnum.Pages
{
  public class IndexModel : PageModel
  {
    public Sport Sport { get; set; }

    public void OnGet()
    {
    }
  }
}
