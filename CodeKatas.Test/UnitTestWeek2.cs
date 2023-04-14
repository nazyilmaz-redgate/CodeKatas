using CodeKatas.Week2;
using FluentAssertions;

namespace CodeKatas.Test;

public class UnitTestWeek2
{
    [Test]
    public void DigitalTimeToBerlinClock_SingleMinuteRow_Success()
    {
        var digitalTime = new DateTime(2023, 3, 6, 0, 0, 0);

        var resultBerlinClock = BerlinClockConverter.ConvertDigitalTimeToBerlinClock(digitalTime);

        var expectedSingleMinuteRow = new SingleMinuteRow(LampState.Off, LampState.Off, LampState.Off, LampState.Off);

        resultBerlinClock._singleMinuteRow.Should().BeEquivalentTo(expectedSingleMinuteRow);
    }
}