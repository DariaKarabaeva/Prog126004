using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class EditionTests
{
    private static Edition _edition;
    
    [SetUp]
    public void Setup()
    {
        _edition = new Edition("Благие Знамения", new List<string> { "Терри Пратчетт", "Нил Гейман" }
            , 1990, "Издательство 1", 12345);
        _edition.Status = EditionStatus.Storage;
    }
    [Test]
    public void ConstructorTest()
    {
        Assert.That(_edition.Name, Is.EqualTo("Благие Знамения"));
        Assert.That(_edition.Year, Is.EqualTo(1990));
        Assert.That(_edition.Publisher, Is.EqualTo("Издательство 1"));
        Assert.That(_edition.InventoryNumber, Is.EqualTo(12345));
        
        Assert.That(_edition.Authors.Count, Is.EqualTo(2));
        Assert.That(_edition.Authors.Contains("Терри Пратчетт") 
                    && _edition.Authors.Contains("Нил Гейман"), Is.True);
    }

    [Test]
    public void GetEditionTypeNameTest()
    {
        Assert.That(_edition.GetStatus(), Is.EqualTo("В хранилище"));
    }
    
    [Test]
    public void GetInfoTest()
    {
        string expectedInfo = "Название: Благие Знамения.";
        expectedInfo += " Год: 1990. ";
        expectedInfo += "Авторы: Терри Пратчетт,Нил Гейман. ";
        expectedInfo += "Издательство: Издательство 1. ";
        expectedInfo += "ИН: 12345. ";
        expectedInfo += "Статус: В хранилище.";
        Assert.That(_edition.GetInfo(), Is.EqualTo(expectedInfo));
    }
}