namespace Pudge;

using System.Collections.Generic;

public class ATC
{
    private List<Client> clients;

    public ATC()
    {

        clients = new List<Client>();
        
    }

    public void AddClient(Client client)
    {

        clients.Add(client);

    }

    public decimal CalculateAvgCost()
    {

        decimal totalCost = 0;
        int Ammount = 0;

        foreach (Client client in clients)
        {
            decimal cost = client.CostCalculator.CalculateCost();
            totalCost += cost;
            ++ Ammount;
        }

        return totalCost / Ammount;

    }
}