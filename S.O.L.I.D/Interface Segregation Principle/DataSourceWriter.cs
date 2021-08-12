using System.Collections.Generic;

namespace Interface_Segregation_Principle
{
    public class DataSourceWriter
    {
        private static void WriteRecords(IDataSourceWriter dataSource, ICollection<Record> records)
        {
            foreach (var record in records) dataSource.WriteRecord(record);
        }
    }
}