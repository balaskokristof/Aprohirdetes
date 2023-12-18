using Aprohirdetes.Properties;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aprohirdetes.Pages
{
    public class ListazModel : PageModel
    {
        private readonly AprohirdetesContext db;
        public List<Aprohird> lista;

		public ListazModel(AprohirdetesContext x)
        {
            db = x;
            lista = db.Aprohirdetesek.ToList();
        }

        public void OnGet()
        {



		}
    }
}
