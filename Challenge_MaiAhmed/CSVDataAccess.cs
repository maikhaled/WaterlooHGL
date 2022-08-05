using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_MaiAhmed
{
    public class CSVDataAccess:IDataAccess
    {
        
        IDataContainer IDataAccess.LoadData()
        {
            string filePath = Factory.GetDataSourcePath();
            if (!File.Exists(filePath))
                throw new Exception("File Path Doesn't Exists: "+ filePath);
            StreamReader reader = new(filePath);
            List<IDataRow> data = new();
            int rowIndex = 0;
            var dataContainer = Factory.CreateDataContainerObj();
           while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if(line == null)
                    continue;
                var rawDataItem = line.Split(',');
                //............................................   
                var dataRow = Factory.CreateDataObj();
                dataRow.DataItems = rawDataItem.Select(x => Factory.CreateBindingString(x)).ToList();
                rowIndex++;
                if (Factory.ColumnNamesExistsInFile && rowIndex == 1)
                    dataContainer.ColumnTitles = rawDataItem;
                else
                    data.Add(dataRow);
            }
            dataContainer.Datarows = data;
            return dataContainer;
        }
        public IList<KeyValuePair<int, string>> LoadKeyValueData()
        {
            throw new NotImplementedException();
        }

    }
}
