namespace Challenge_MaiAhmed
{
    public interface IDataContainer
    {
        IList<IDataRow> Datarows { get; set; }
        IList<string> ColumnTitles { get; set; }
    }
}