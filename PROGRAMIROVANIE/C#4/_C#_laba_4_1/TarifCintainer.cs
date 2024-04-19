namespace DannyBrown;

public class TarifCintainer
{

    private List<Tarif> tarifs;

    public TarifCintainer()
    {

        tarifs = new List<Tarif>();

    }    

    public void addTarif( Tarif tarif )
    {

        tarifs.Add( tarif );

    }

    public void removeTarif( Tarif tarif )
    {

        tarifs.Remove( tarif );

    }

    public long finalRes()
    {

        long Result = 0;

        foreach( Tarif tarif in tarifs )
            Result += tarif.TarifCost * tarif.UsersAmmount;

        return Result;

    }

}