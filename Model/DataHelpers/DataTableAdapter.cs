using SharedModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorgovoPosredFirma.Model.DataHelpers
{
    public static class DataTableAdapter
    {
        public static DataTable AdaptToDataTable(IEnumerable<object> items)
        {
            if (items == null || !items.Any())
                return new DataTable(); //пустая

            var table = new DataTable();

            // определяем тип
            var firstItemType = items.First().GetType();

            // создаём столбцы
            var properties = firstItemType.GetProperties();
            foreach (var prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            // заполняем таблицу
            foreach (var item in items)
            {
                var row = table.NewRow();
                foreach (var prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            return table;
        }
    }
}
