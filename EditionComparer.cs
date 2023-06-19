using System.Collections.Generic;

public class EditionComparer : IComparer<Edition>
{
    public int Compare(Edition x, Edition y)
    {
        return x.InventoryNumber.CompareTo(y.InventoryNumber);
    }
}