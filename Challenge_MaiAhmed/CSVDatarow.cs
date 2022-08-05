namespace Challenge_MaiAhmed
{
    public class CSVDatarow : IDataRow
    {
        public IList<string> DataItems { get; set; } = new List<string>();
        public override string ToString()
        {
            return $"Data Loaded:{DataItems.Count} row(s)";
        }
        public CSVDatarow() { }
        public CSVDatarow(IList<string> dataItems)
        {
            DataItems = dataItems;
        }
    }
}