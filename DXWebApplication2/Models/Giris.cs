namespace DXWebApplication2.Models
{
    public class Giris
    {



        static Random rnd1 = new Random();

        public string? userid { get; set; }
        public string? password { get; set; }


        public static List<Giris> CreateData()
        {
            List<Giris> data = new List<Giris>();
            data.Add(new Giris { userid = "ahmetsuatdirav4@gmail.com", password = "pass" });
            return data;
        }

        static DateTime GenerateOrderDate()
        {
            int startYear = DateTime.Today.Year - 3;
            int endYear = DateTime.Today.Year;
            return new DateTime(rnd1.Next(startYear, endYear), rnd1.Next(1, 13), rnd1.Next(1, 29));
        }



    }
}
