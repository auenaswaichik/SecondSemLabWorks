namespace DannyBrown;

public class Tarif
{

    private string adressATS;
    private long usersAmmount;
    private long tarifCost;

    public Tarif( string adress , long cost )
    {

        adressATS = adress;
        tarifCost = cost;
        usersAmmount = 0;

    }

    public long UsersAmmount
    {

        get { return usersAmmount; }
        set { usersAmmount = value; }

    }

    public long TarifCost
    {

        get { return tarifCost; }
        set { tarifCost = value; }

    }

    public void addUsers( long newAmmount )
    {

        usersAmmount += newAmmount;

    }

    public void changeCost( long newCost )
    {

        tarifCost += newCost;

    }

}