using Pudge;

ATC ATCOperator = new ATC();

ITarifCostCalculation usualTarif = new UsualTarif( "328" , 10 );
Client client1 = new Client("John", usualTarif);

ITarifCostCalculation lgothTarif = new LgothTarif(  "22" , 8 );
Client client2 = new Client("Jane", lgothTarif );

ATCOperator.AddClient(client1);
ATCOperator.AddClient(client2);

decimal avgCost = ATCOperator.CalculateAvgCost();

Console.WriteLine($"Total cost for all clients: {avgCost}");
