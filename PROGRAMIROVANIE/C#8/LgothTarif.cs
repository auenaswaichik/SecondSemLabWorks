namespace Pudge;

public class LgothTarif : ITarifCostCalculation
{

    public string TarifNumber{ get; set; }
    public decimal TarifCost{ get; set; }

    public LgothTarif( string tarifNumber , decimal tarifCost )
    {

        TarifNumber = tarifNumber;
        TarifCost = tarifCost;

    }
    public decimal CalculateCost()
    {

        return TarifCost / 10;

    }

}