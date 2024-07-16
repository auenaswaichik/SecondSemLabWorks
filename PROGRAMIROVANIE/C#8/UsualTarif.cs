namespace Pudge;

public class UsualTarif : ITarifCostCalculation
{

    public string TarifNumber{ get; set; }
    public decimal TarifCost{ get; set; }

    public UsualTarif( string tarifNumber , decimal tarifCost )
    {

        TarifNumber = tarifNumber;
        TarifCost = tarifCost;

    }
    public decimal CalculateCost()
    {

        return TarifCost;

    }
    
}