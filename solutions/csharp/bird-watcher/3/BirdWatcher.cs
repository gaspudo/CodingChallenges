class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => [0, 2, 5, 3, 7,8,4];
    

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];    
    }

    public void IncrementTodaysCount()
    {
        int ultimo = birdsPerDay[birdsPerDay.Length - 1];
        ultimo++;
        birdsPerDay[birdsPerDay.Length - 1] = ultimo;
    }

    public bool HasDayWithoutBirds()
    {
        bool semPassaro = false;
        foreach (var item in birdsPerDay) {
            if (item == 0) return true;  
        }
        return semPassaro;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for(int i = 0; i < numberOfDays; i++) {
            sum += birdsPerDay[i];
        }
        return sum;
    }

    public int BusyDays()
    {
        int days = 0;
        foreach(var item in birdsPerDay) {
            if (item >= 5) {
                days++;
            }
        }
        return days;
    }
}
