
namespace cuclovod
{

    class Store
    {

        private List<Client> clientContainer;

        public Store()
        {

            clientContainer = new List<Client>();

        }

        public void AddClient( Client newClient )
        {

            clientContainer.Add( newClient );

        }

        public long ClientTarifPrice( string newClientName )
        {

            foreach( var item in clientContainer )
            {

                if( item.ClientName == newClientName )
                    return item.ClientsTarifCost();

            }

            return -1;

        }

        public long TarifTotalPrice( )
        {

            long summ = 0;

            foreach( var item in clientContainer )
            {

                summ += item.ClientsTarifCost();

            }

            return summ;

        }


    };

}