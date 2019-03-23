namespace DAL.Models
{
    public class Pracownik
    {
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int StanowiskoID { get; set; }
        public decimal Pensja { get; set; }
    }
}