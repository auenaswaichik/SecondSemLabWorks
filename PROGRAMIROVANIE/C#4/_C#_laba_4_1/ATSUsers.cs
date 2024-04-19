namespace DannyBrown;

public class ATSUsers
{

    private TarifCintainer tarifCintainer;

    public ATSUsers()
    {

        tarifCintainer ??= new TarifCintainer();
        return;

    }

    public TarifCintainer TarifCintainer
    {

        get { return tarifCintainer; }

    }

}