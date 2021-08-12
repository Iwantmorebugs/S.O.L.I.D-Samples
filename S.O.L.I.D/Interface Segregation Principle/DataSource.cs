using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Interface_Segregation_Principle
{
    //originally public class DataSource : IDataSource

    // with separate interface.
    public class DataSource : IDataSourceReader, IDataSourceWriter
    {
        private readonly ICollection<Record> _records = new Collection<Record>();

        public Record ReadRecord(int id)
        {
            return _records.FirstOrDefault(x => x.Id == id);
        }

        public void WriteRecord(Record record)
        {
            _records.Add(record);
        }

    }
}