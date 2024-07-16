using cuclovod;

Store store = new Store();

Client client1 = new Client( new Tarif( 123 , "mahorka" ) , "444444444" , "iluha" );
Client client2 = new Client( new Tarif( 456 , "vaibic" ) , "1111111111" , "vadim" );
Client client3 = new Client( new Tarif( 789 , "breakdance" ) , "23456789" , "parovoz" );

store.AddClient( client1 );
store.AddClient( client2 );
store.AddClient( client3 );

client1.AddTarif( new Tarif( 222333 , "ooaaa" ) );
client1.AddTarif( new Tarif( 1 , "chumba" ) );
client2.AddTarif( new Tarif( 4 , "samolet" ) );

Console.WriteLine( "Price of iluha's calls is " + store.ClientTarifPrice( "iluha" ) );

Console.WriteLine( "Tarif total price is " + store.TarifTotalPrice() );
