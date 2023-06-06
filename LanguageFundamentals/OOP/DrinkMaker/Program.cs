Soda Sprite = new Soda(false, "Sprite", "Green", 60.8, 200);
Coffee Starbucks = new Coffee("light", "african", "Starbucks African Light-Roast", "brown", 101.7, 150);
Wine Red = new Wine("Germany", 1954, "Red Wine", "Red", 74.5, 20);

// Sprite.ShowDrink();
// Starbucks.ShowDrink();
// Red.ShowDrink();

List<Drink> Drinks = new List<Drink> {Sprite, Starbucks, Red};

foreach (Drink d in Drinks)
{
    d.ShowDrink();
}

// Coffee MyDrink = new Soda();
// coffee does not have the same fields