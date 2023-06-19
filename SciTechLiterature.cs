public class SciTechLiterature : Edition
{
    public string Sphere;
    public string Annotation;

    public override string GetInfo()
    {
        var result = base.GetInfo();
        if (Sphere != default)
            result += $" Область: {Sphere}.";
        if (Annotation != default)
            result += $" Аннотация: {Annotation}.";
        return result;
    }
}