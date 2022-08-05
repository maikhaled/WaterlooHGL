using System.ComponentModel;
namespace Challenge_MaiAhmed
{
    public interface IDataAccess
    {
        IDataContainer LoadData();
        bool SaveData(IEnumerable<IEnumerable<string>> userData, string filePath);
        IList<KeyValuePair<int, string>> LoadKeyValueData();
    }
}