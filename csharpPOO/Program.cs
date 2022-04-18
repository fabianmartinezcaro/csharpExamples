Car car1 = new Car(24.3, 2.34);
Console.WriteLine(car1.GetCarInfo());

//car1.setExtras(true, "Black Leather");
Console.WriteLine(car1.getExtras());


// SPLIT CON PROPIEDADES DE LA CLASE Y SUS CONSTRUCTORES:
partial class Car {

    // Propiedades
    private int Wheels;
    private int Doors;
    private double ySize;
    private double xSize;
    private bool airConditioner;
    private string typeOfSeat;

    // Constructor
    public Car () {

        Wheels = 4;
        Doors = 2;
        ySize = 2.32;
        xSize = 1.25;
        typeOfSeat = "sedar";
        airConditioner = false;

    }

    public Car(double NewYSize, double NewXSize) {

        Wheels = 4;
        ySize = NewYSize;
        xSize = NewXSize;
        typeOfSeat = "sedar";
        airConditioner = false;

    }

}

// SPLIT CON GETTERS Y SETTERS:
partial class Car{
    public String GetCarInfo() {

        return $"Wheels: {Wheels}\nHeight: {ySize}.\nWidth: {xSize}";

    }

    public void setExtras(bool airConditioner, string typeOfSeat) {

        this.airConditioner = airConditioner;
        this.typeOfSeat = typeOfSeat;

    }

    public string getExtras() {

        return $"Air Conditioner: {airConditioner} \nType of Seat: {typeOfSeat}";

    }

    public int GetWheels() {

        return Wheels;

    }

    public int GetDoors() {

        return Doors;

    }

    public double GetYSize() {

        return ySize;

    }

    public double GetXSize() {

        return xSize;

    }

}







