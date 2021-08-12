namespace Interface_Segregation_Principle
{
    public interface IDataSourceReader
    {
        Record ReadRecord(int id);
    }
}