using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class EditionSubclassesTests
{
    private static SciTechLiterature _sciTech;
    private static Fiction _fiction;
    private static PeriodicLiterature _periodic;
    
    [SetUp]
    public void Setup()
    {
        _sciTech = new SciTechLiterature();
        _sciTech.Name = "Очень важное исследование";
        _sciTech.Annotation = "Невероятно важно";
        _sciTech.Sphere = "Философия";
        
        _fiction = new Fiction();
        _fiction.Name = "Война и мир";
        _fiction.Genre = "Роман-эпопея";
        _fiction.Language = "Русский";
        _fiction.Type = FictionType.Prose;
        
        _periodic = new PeriodicLiterature();
        _periodic.Name = "Мурзилка";
        _periodic.Period = new Tuple<int, int>(1924, 2023);
        _periodic.Type = PeriodicType.Magazine;
    }

    [Test]
    public void ScienceTest()
    {
        var expected = "Название: Очень важное исследование. "
                       + "Статус: В хранилище. "
                       + "Область: Философия. "
                       + "Аннотация: Невероятно важно.";
        Assert.That(_sciTech.GetInfo(), Is.EqualTo(expected));
    }
    
    [Test]
    public void FictionTest()
    {
        var expected = "Название: Война и мир. "
                       + "Статус: В хранилище. "
                       + "Жанр: Роман-эпопея. "
                       + "Язык: Русский. "
                       + "Тип: Проза.";
        Assert.That(_fiction.GetInfo(), Is.EqualTo(expected));
    }
    
    [Test]
    public void PeriodicTest()
    {
        var expected = "Название: Мурзилка. "
                       + "Статус: В хранилище. "
                       + "Период выхода: 1924-2023. "
                       + "Тип: Журнал.";
        Assert.That(_periodic.GetInfo(), Is.EqualTo(expected));
    }
}