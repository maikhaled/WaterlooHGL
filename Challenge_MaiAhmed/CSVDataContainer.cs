using System.Collections;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Challenge_MaiAhmed
{
    [Serializable]
    internal class CSVDataContainer : IDataContainer, IListSource
    {
        public IList<IDataRow> Datarows { get; set; }
        public IList<string> ColumnTitles { get; set; }

        public bool ContainsListCollection => throw new NotImplementedException();

        public CSVDataContainer()
        {
            Datarows = new List<IDataRow>();
            ColumnTitles= new List<string>();
        }

        public CSVDataContainer(List<IDataRow> datarows)
        {
            this.Datarows = datarows;
            ColumnTitles = new List<string>();
        }

        public IList GetList()
        {
            return this.Datarows.ToList();
        }
    }
}