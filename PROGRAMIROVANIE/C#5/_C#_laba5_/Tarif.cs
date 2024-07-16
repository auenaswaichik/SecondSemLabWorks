
namespace cuclovod
{

    class Tarif
    {

        private long tarifCost;
        private string tarifName;
        public enum Gang
        {

            YBITOK,
            PRIBIL

        }
        

        public Tarif()
        {

            TarifCost = 0;
            TarifName = "";

        }
        public Tarif( long newCost , string newName )
        {

            TarifCost = newCost;
            TarifName = newName;

        }

        public void ChangeNewCost( long newCost )
        {

            tarifCost += newCost;

        }

        public long TarifCost
        {

            get{ return tarifCost; }
            set{ tarifCost = value < 0 ? 0 : value; }

        }

        public string TarifName
        {

            get{ return tarifName; }
            set{ tarifName = value; }

        }

    };

}