public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }



    public override string ToString()
    {
        return $@"
    Name:     {Name}
    Category:    {Category}
    Price:    {Price}";
    }
}
