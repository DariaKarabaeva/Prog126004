using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Section : IEnumerable
{
    public string Name { get; set; }
    public int Count {
        get => Editions.Count; 
    }
    private List<Edition> Editions;
    
    public Section(IEnumerable<Edition> editions)
    {
        Editions = new List<Edition>(editions.Distinct());
    }
        
    public IEnumerator<Edition> GetEnumerator() => Editions.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}