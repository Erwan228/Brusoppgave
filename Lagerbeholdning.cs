namespace Brusoppgave
{
    public class Lagerbeholdning
    {
        public Drikke Drikke { get; }
        private int _antall;
        public Lagerbeholdning(Drikke drikke, int antall)
        {
            Drikke = drikke;
            _antall = antall;
        }
        public int GetAntall()
        {
            return _antall;
        }
        public void MindreAntall(int reduce)
        {
            _antall -= reduce;
        }
        public bool IsAvailable(string navn)
        {
            return Drikke.GetNavn() == navn && GetAntall() > 0;
        }
    }
}
