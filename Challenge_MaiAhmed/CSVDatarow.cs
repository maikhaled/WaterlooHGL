namespace Challenge_MaiAhmed
{
    public class CSVDatarow : IDataRow
    {
        public IList<IStringValue> DataItems { get; set; } = new List<IStringValue>();
        public override string ToString()
        {
            return $"Data Loaded:{DataItems.Count} row(s)";
        }
        public CSVDatarow() { }
        public CSVDatarow(IList<IStringValue> dataItems)
        {
            DataItems = dataItems;
        }
    }
}