using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_MaiAhmed
{
    public static  class Factory
    {
        public static bool ColumnNamesExistsInFile { get; private set; } = true;
        public static bool ColumnNamesExistsInKeyValueFile { get; private set; } = true;
        private static string _dataSourcePath  = StaticStrings.DataFilePath;
        public  static IDataRow CreateDataObj()
        {
            return new CSVDatarow();
        }
        public static IDataAccess CreateDataAccessObj()
        {
            return new CSVDataAccess();
        }
        
        public static IStringValue CreateBindingString()
        {
            return new CSVStringValue();
        }
        public static IStringValue CreateBindingString(string value)
        {
            return new CSVStringValue(value);
        }

        internal static IDataContainer CreateDataContainerObj()
        {
            return new CSVDataContainer();
        }
        internal static IDataContainer CreateDataContainerObj(List<IDataRow> data)
        {
            return new CSVDataContainer(data);
        }

        public static string GetDataSourcePath()
        {
            return _dataSourcePath;
        }
        public static void UpdateDataSourcePath(string newDataSourceFilePath)
        {
            _dataSourcePath = newDataSourceFilePath;
        }
        public static string GetKeyValueDataFilePath()
        {
            return Challenge_MaiAhmed.StaticStrings.KeyValueFilePath;
        }
    }
}
