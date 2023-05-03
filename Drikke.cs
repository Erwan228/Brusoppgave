namespace Brusoppgave
{
    public class Drikke
    {
        private string _navn;
        private int _pris;
        public Drikke(string navn, int pris)
        {
            _navn = navn;
            _pris = pris;
        }
        public void Show()
        {
            Console.WriteLine($"{_navn} koster {_pris}kr!");
        }
        public string GetNavn()
        {
            return _navn.ToString();
        }
        public int GetPris()
        {
            return _pris;
        }
    }
}
