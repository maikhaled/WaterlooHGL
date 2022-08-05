using System.Runtime.Serialization;

namespace Challenge_MaiAhmed
{
    [Serializable]
    internal class CSVDataContainer : IDataContainer
    {
        public IList<IDataRow> Datarows {get;set;}
        public IList<string> ColumnTitles { get; set; }
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

       
    }
}