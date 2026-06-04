class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int minutes) => 40 - minutes;

    public int PreparationTimeInMinutes(int layers) => layers * 2;

    public int ElapsedTimeInMinutes(int layers, int minSpent) => layers * 2 + minSpent;
}
