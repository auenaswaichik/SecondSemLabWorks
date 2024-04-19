using DannyBrown;

ATSUsers atsUsers = new ATSUsers();

Tarif tarifFirst = new Tarif( "memchik" , -111 );
Tarif tarifSecond = new Tarif( "smeshok" , 40 );
Tarif tarifThird = new Tarif( "meshok" , 80 );

atsUsers.TarifCintainer.addTarif( tarifFirst );
atsUsers.TarifCintainer.addTarif( tarifSecond );
atsUsers.TarifCintainer.addTarif( tarifThird );

Console.WriteLine( "Total cost: " + atsUsers.TarifCintainer.finalRes() );

tarifFirst.addUsers( 228 );
tarifSecond.addUsers( 14 );
tarifThird.addUsers( 88 );

Console.WriteLine( "Total cost: " + atsUsers.TarifCintainer.finalRes() );