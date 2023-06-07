public interface INeedFuel
{
    string FuelType {get;set;}
    int FuelTotal {get;set;}
    string Name {get;set;}

    void GiveFuel(int Amount);
}

