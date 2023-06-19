using System;
using System.Collections.Generic;
using NUnit.Framework;


[TestFixture]
public class IComparableTests
{
    private static Edition edition1;
    private static Edition edition2;
    private static Edition edition3;
    private static EditionComparer comparer;
    private static Edition[] editions;
    private static Section section;
    
    [SetUp]
    public void Setup()
    {
        edition1 = new Edition("1234", new List<string> {"aaa", "b"}, 2020, "publisher", 2);
        edition2 =  new Edition("1232", new List<string> {"aab"}, 2021, "publisher", 1);
        edition3 =  new Edition("1234", new List<string> {"aaa"}, 2022, "publisher", 3);
        comparer = new EditionComparer();
        editions = new Edition[] { edition1, edition2, edition3 };
        section = new Section(editions);
    }

    [Test]
    public void CompareToTest()
    {
        Assert.That(edition1.CompareTo(edition2), Is.LessThan(0));
        Assert.That(edition1.CompareTo(edition3), Is.GreaterThan(0));
    }

    [Test]
    public void ComparerTest()
    {
        Assert.That(comparer.Compare(edition1, edition2), Is.GreaterThan(0));
        Assert.That(comparer.Compare(edition1, edition3), Is.LessThan(0));
    }

    [Test]
    public void CatalogueCountTest()
    {
        Assert.That(section.Count, Is.EqualTo(3));
    }
    
    [Test]
    public void IEnumerableTest()
    {
        var i = 0;
        foreach(var member in section)
            Assert.That(member, Is.SameAs(editions[i++]));
    }
}