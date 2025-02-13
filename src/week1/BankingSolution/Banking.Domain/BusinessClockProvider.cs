namespace Banking.Domain;

public class BusinessClockProvider(TimeProvider _clock) : IProvideTheBusinessClockForBonusCalculation
{
  public bool WeAreCurrentlyDuringBusinessHours()
  {
    var dayOfTheWeek = _clock.GetLocalNow().DayOfWeek;

    if(dayOfTheWeek == DayOfWeek.Saturday)
    {
      return true;
    }
    if(dayOfTheWeek == DayOfWeek.Monday)
    {
      return false;
    }
    return false;
  }
}
