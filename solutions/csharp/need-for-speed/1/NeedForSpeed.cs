class RemoteControlCar
{
    public int Speed { get; }
    public int BatteryDrain { get; }

    private int battery = 100;
    private int drivenMeters = 0;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        Speed = speed;
        BatteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return battery < BatteryDrain;
    }

    public int DistanceDriven()
    {
        return drivenMeters;
    }

    public void Drive()
    {
        if (BatteryDrained())
            return;

        drivenMeters += Speed;
        battery -= BatteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    public int Distance { get; }

    public RaceTrack(int distance)
    {
        Distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int drivesNeeded = (Distance + car.Speed - 1) / car.Speed;
        return drivesNeeded * car.BatteryDrain <= 100;
    }
}