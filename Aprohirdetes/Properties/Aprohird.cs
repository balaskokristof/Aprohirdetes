namespace Aprohirdetes.Properties
{
	public class Aprohird
	{
        public int Id { get; set; }

        public string Cim { get; set; }

        public string Leiras { get; set; }

        public DateTime Megjelenes { get; set; }

        public string Helyszin { get; set; }

        public string Email { get; set; }

        public bool Aktualis { get; set; }



        public Aprohird(string Cim, string Leiras, string Helyszin, string Email)
        {
			this.Cim = Cim;
			this.Leiras = Leiras;
			this.Helyszin = Helyszin;
			this.Email = Email;
			this.Megjelenes = DateTime.Now;
			this.Aktualis = true;
		}
       
    }
}
