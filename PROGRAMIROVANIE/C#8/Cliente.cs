namespace Pudge;

public class Client
{

    public string Name { get; set; }
    public ITarifCostCalculation CostCalculator { get; set; }

    public Client( string name, ITarifCostCalculation costCalculator )
    {
        Name = name;
        CostCalculator = costCalculator;
    }

}