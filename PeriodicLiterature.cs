using System;

public class PeriodicLiterature : Edition
{
    public Tuple<int, int> Period;
    public PeriodicType Type;

    public string GetPeriodicType()
    {
        if (Type == PeriodicType.Magazine)
            return "Журнал";
        return "Газета";
    }

    public override string GetInfo()
    {
        var result = base.GetInfo();
        if (Period != default)
            result += $" Период выхода: {Period.Item1}-{Period.Item2}.";
        result += $" Тип: {GetPeriodicType()}.";
        return result;
    }
}