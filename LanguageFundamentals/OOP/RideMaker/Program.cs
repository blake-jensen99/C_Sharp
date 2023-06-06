Ride Scooter = new Ride("Scooter", "Blue", 1, false);
Ride Car = new Ride("Car", "Yellow");
Ride Rowboat = new Ride("Rowboat", "Grey", 2, false);
Ride Plane = new Ride("Plane", "Red", 200);


List<Ride> rides = new List<Ride> {Scooter, Car, Rowboat, Plane};

foreach (Ride item in rides) {
    item.ShowInfo();
}

Scooter.Drive(100);
Scooter.ShowInfo();