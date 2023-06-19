public class Fiction : Edition
{
    public string Genre;
    public string Language;
    public FictionType Type;

    public string GetFictionType()
    {
        if (Type == FictionType.Poetry)
            return "Поэзия";
        return "Проза";
    }

    public override string GetInfo()
    {
        var result = base.GetInfo();
        if (Genre != default)
            result += $" Жанр: {Genre}.";
        if (Language != default)
            result += $" Язык: {Language}.";
        result += $" Тип: {GetFictionType()}.";
        return result;
    }
}