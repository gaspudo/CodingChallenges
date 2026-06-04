class RemoteControlCar
{
    private int Battery = 100;
    private int MetersDriven = 0;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay() => $"Driven {MetersDriven} meters";

    public string BatteryDisplay() => Battery > 0? $"Battery at {Battery}%" : "Battery empty";

    public void Drive()
    {
        if (Battery <= 0) Console.WriteLine("Battery empty");
        else {
        Battery--;
        MetersDriven+=20;
        }
    }
}
