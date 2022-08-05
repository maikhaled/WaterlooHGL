namespace Challenge_MaiAhmed
{
    public interface IDataAccess
    {
        IDataContainer LoadData();
        IList<KeyValuePair<int, string>> LoadKeyValueData();
    }
}