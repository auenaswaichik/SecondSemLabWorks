namespace LIL_YACHTY;

public interface ITelevision
{

    string Name{ get; set; }
    string Type{ get; set; }
    string GetInfo();
    void ShowConnection( IConnection connection ); 

}