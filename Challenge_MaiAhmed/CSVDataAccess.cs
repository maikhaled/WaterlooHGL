using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_MaiAhmed
{
    public class CSVDataAccess:IDataAccess
    {
        /// <summary>
        ///  Loads the a csv file into a KeyValue pair
        ///  1st item is the id, 2nd is the value, other data will be neglected 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"> Throws exception if the file path doesn't exists</exception>
        public IList<KeyValuePair<int, string>> LoadKeyValueData()
        {
            string filePath = Factory.GetKeyValueDataFilePath();
            if (!File.Exists(filePath))
                throw new Exception("File Path Doesn't Exists: " + filePath);
            List<KeyValuePair<int, string>> data = new();
            using (StreamReader reader = new(filePath))
            {
                //.... we don't need the column names
                //.... so consume the first Readline in casne there is headers
                if (Factory.ColumnNamesExistsInKeyValueFile)
                    reader.ReadLine();
                //..........................................................
                while (!reader.EndOfStream)
                {
                    var dataItem = ReadLineToKeyValue(reader);
                    if(dataItem.Value != null && dataItem.Value.Length>0)
                        data.Add(dataItem);
                }
            }
            return data;

        }
        /// <summary>
        /// Loads a CSV file into our custom data container schema.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception">Throws exception if the file path doesn't exists</exception>
        public IDataContainer LoadData()
        {
            string filePath = Factory.GetDataSourcePath();
            if (!File.Exists(filePath))
                throw new Exception("File Path Doesn't Exists: "+ filePath);
            var dataContainer = Factory.CreateDataContainerObj();
            using(StreamReader reader = new(filePath))
            {
                if (Factory.ColumnNamesExistsInFile)
                {
                    var rawDataItem = ReadLineToStringArray(reader);
                    if (rawDataItem is null)
                        return dataContainer;
                    dataContainer.ColumnTitles = rawDataItem;
                }
                //..........................................................
                List<IDataRow> data = new();
                while (!reader.EndOfStream)
                {
                    data.Add(ReadLineToDataRow(reader));
                }
                dataContainer.Datarows = data;
            }
            return dataContainer;
        }
        //..........................................................................
        private string[]? ReadLineToStringArray(StreamReader reader)
        {
            string line = reader.ReadLine() ?? "";
            if (line is null || line.Length == 0)
                return null;
            var rawDataItem = line.Split(',');
            return rawDataItem;
        }
        private IDataRow ReadLineToDataRow(StreamReader reader)
        {
            var dataRow = Factory.CreateDataObj();
            var rawDataItem = ReadLineToStringArray(reader);
            if (rawDataItem is null || rawDataItem.Length == 0)
                return dataRow;
            dataRow.DataItems = rawDataItem.Select(x => Factory.CreateBindingString(x)).ToList();
            return dataRow;
        }
        private KeyValuePair<int, string> ReadLineToKeyValue(StreamReader reader)
        {
            var dataArray = ReadLineToStringArray(reader);
            if (dataArray is null || dataArray.Length < 2) 
                return new KeyValuePair<int, string>();
            return ParseDataToKeyValue(dataArray);
        }
        private KeyValuePair<int,string> ParseDataToKeyValue(string[] dataArray)
        {
            int keyValue = -1;
            if (!int.TryParse(dataArray[0], out keyValue))
                return new KeyValuePair<int, string>();
            var result = new KeyValuePair<int, string>(keyValue, dataArray[1]);
            return result;
        }
    }
}
