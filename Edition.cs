using System;
using System.Collections.Generic;
using System.Text;


public class Edition
{
    public string Name { get; set; }
    public List<string> Authors { get; set; }
    public int Year { get; set; }
    public string Publisher  { get; set; }
    public readonly int InventoryNumber;
    public EditionStatus Status;
    public int Price;
    
    public Edition() {}

    public Edition(string name, List<string> authors, int year, string publisher, int inventoryNumber)
    {
        Name = name;
        Authors = authors;
        Year = year;
        Publisher = publisher;
        InventoryNumber = inventoryNumber;
    }

    public string GetStatus()
    {
        if (Status == EditionStatus.ClientHome)
            return "Выдана на дом";
        if (Status == EditionStatus.ReadingRoom)
            return "Выдана в читальный зал";
        return "В хранилище";
    }
    
    public virtual string GetInfo()
    {
        var result = new StringBuilder();
        if (Name != default)
            result.Append($"Название: {Name}.");
        if (Year != default)
            result.Append($" Год: {Year}.");
        if (Authors != default)
            result.Append($" Авторы: {string.Join(',', Authors)}.");
        if (Publisher != default)
            result.Append($" Издательство: {Publisher}.");
        if (InventoryNumber != default)
            result.Append($" ИН: {InventoryNumber}.");
        result.Append($" Статус: {GetStatus()}.");
        if (Price != 0)
            result.Append($" Цена: {Price}.");
        return result.ToString();
    }
}
