namespace CodeKatas.Week2;

public static class BerlinClockConverter
{

    public static BerlinClock ConvertDigitalTimeToBerlinClock(DateTime digitalTime)
    {
        return new BerlinClock();
    }
}


public class BerlinClock
{
    public readonly SingleMinuteRow _singleMinuteRow;
}

public record SingleMinuteRow(LampState first, LampState second, LampState third, LampState fourth);
