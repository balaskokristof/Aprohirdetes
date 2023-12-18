using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aprohirdetes.Pages
{
    public class FelveszModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
			string Cim = Request.Form["Cim"];
			string Leiras = Request.Form["Leiras"];
			string Helyszin = Request.Form["Helyszin"];
			string Email = Request.Form["Email"];

            Console.WriteLine(Cim);

            var db = new Aprohirdetes.Properties.Aprohird(Cim, Leiras, Helyszin, Email);
            var dbcontext = new Aprohirdetes.Properties.AprohirdetesContext();
            dbcontext.Database.EnsureCreated();
            dbcontext.Aprohirdetesek.Add(db);
            dbcontext.SaveChanges();
		}
    }
}
