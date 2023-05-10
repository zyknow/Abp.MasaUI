using BlazorComponent;

namespace Zyknow.Abp.MasaUI;

public class TableHeaderDictionary<TItem> : Dictionary<string, List<DataTableHeader<TItem>>>
{
    public List<DataTableHeader<TItem>> Get<T>()
    {
        return this.GetOrAdd(typeof(T).FullName, () => new List<DataTableHeader<TItem>>());
    }
}