
namespace cuclovod
{

    class Client
    {

        private List <Tarif> tarifContainer;
        private string clientNumber;
        private string clientName;

        public Client()
        {

            tarifContainer = new List<Tarif>();
            ClientNumber = "";
            ClientName = "";

        }

        public Client( Tarif newTarif , string newNumber , string newName )
        {

            tarifContainer = new List<Tarif>();
            tarifContainer.Add( newTarif );
            ClientName = newName;
            ClientNumber = newNumber;

        }

        public string ClientName
        {

            get{ return clientName; }
            set{ clientName = value; }

        }

        public string ClientNumber
        {

            get{ return clientNumber; }
            set{ clientNumber = value; }

        }

        public void AddTarif( Tarif newTarif )
        {

            tarifContainer.Add( newTarif );

        }

        public long ClientsTarifCost()
        {

            long summ = 0;

            foreach (var item in tarifContainer )
            {

                summ += item.TarifCost;

            }

            return summ;

        }


    };

}
