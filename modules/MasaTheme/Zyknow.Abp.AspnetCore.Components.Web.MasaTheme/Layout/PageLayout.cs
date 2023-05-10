using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BlazorComponent;
using Volo.Abp.DependencyInjection;
using Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.PageToolbars;

namespace Zyknow.Abp.AspnetCore.Components.Web.MasaTheme.Layout;

public class PageLayout : IScopedDependency, INotifyPropertyChanged
{
    private string _menuItemName;
    private string title;

    // TODO: Consider using this property for setting Page Title too.
    public virtual string Title
    {
        get => title;
        set
        {
            title = value;
            OnPropertyChanged();
        }
    }

    public string MenuItemName
    {
        get => _menuItemName;
        set
        {
            _menuItemName = value;
            OnPropertyChanged();
        }
    }

    public virtual ObservableCollection<BreadcrumbItem> BreadcrumbItems { get; set; } = new();

    public virtual ObservableCollection<PageToolbarItem> ToolbarItems { get; set; } = new();

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}