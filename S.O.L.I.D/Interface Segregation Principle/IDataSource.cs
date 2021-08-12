namespace Interface_Segregation_Principle
{
    public interface IDataSource
    {
        Record ReadRecord(int id);
        void WriteRecord(Record record);
    }
}