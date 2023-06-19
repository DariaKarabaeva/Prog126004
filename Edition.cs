using System;
using System.Collections.Generic;
using System.Text;

namespace HW12
{
    public class Edition
    {
        public string Name { get; set; }
        public List<string> Authors { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }
        public readonly int InventoryNumber;
        public EditionStatus Status;
        public int Price;

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
            if (Status == EditionStatus.Storage)
                return "В хранилище";
            if (Status == EditionStatus.ClientHome)
                return "Выдана на дом";
            if (Status == EditionStatus.ReadingRoom)
                return "Выдана в читальный зал";
            return "Нет статуса";
        }

        public string GetInfo()
        {
            var result = new StringBuilder();
            result.Append($"Название: {Name}. Год: {Year}.");
            result.Append($" Авторы: {string.Join(',', Authors)}.");
            result.Append($" Издательство: {Publisher}.");
            result.Append($" ИН: {InventoryNumber}.");
            var status = GetStatus();
            if (status != "Нет статуса")
                result.Append($" Статус: {status}.");
            if (Price != 0)
                result.Append($" Цена: {Price}.");
            return result.ToString();
        }
    }
}
