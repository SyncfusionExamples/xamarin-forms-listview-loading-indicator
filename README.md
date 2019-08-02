# Show busy indicator on loading Xamarin.Forms ListView

The SfListView allows displaying the [SfBusyIndicator](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfBusyIndicator.XForms~Syncfusion.SfBusyIndicator.XForms.SfBusyIndicator.html) when loading the bounded items. The busy indicator can be enabled and disabled by using [IsBusy](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfBusyIndicator.XForms~Syncfusion.SfBusyIndicator.XForms.SfBusyIndicator~IsBusy.html) property.

Create a IsLoading boolean property in view model and bind it to the IsBusy property. By setting the value to IsLoading property, the busy indicator will be enabled and disabled into the view till the items loaded in the SfListView.

```
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms"
             xmlns:busyIndicator="clr-namespace:Syncfusion.SfBusyIndicator.XForms;assembly=Syncfusion.SfBusyIndicator.XForms">
    <Grid>
        <syncfusion:SfListView x:Name="listView" 
                             ItemsSource="{Binding ContactInfo}" 
                             ItemSize="110">
        </syncfusion:SfListView>
        <busyIndicator:SfBusyIndicator x:Name="busyIndicator" InputTransparent="True"
                                       AnimationType="SingleCircle" 
                                       IsBusy="{Binding IsLoading, Mode=TwoWay}" 
                                       TextColor="Magenta"
                                       ViewBoxWidth="50"
                                       ViewBoxHeight="50"/>
    </Grid>
</ContentPage>

```
When both SfBusyIndicator and ListView loaded with same row and column, you need to set InputTransparent as True to SfBusyindicator in order to pass touch interaction to listview in iOS platform.

```
public class ViewModel : INotifyPropertyChanged
{
    private bool isLoading = false;

    public bool IsLoading
    {
        get { return isLoading; }
        set
        {
            this.isLoading = value;
            OnPropertyChanged("IsLoading");
        }
    }

    private async void GenerateItems()
    {
        IsLoading = true;
        await Task.Delay(5000);
        for (int i = 0; i < 30; i++)
        {
            var contact = new Model(CustomerNames[i], ContactNumber[i]);
            ContactInfo.Add(contact);
        }
        IsLoading = false;
    }
}
```
To know more about showing busy indocator on loading listview, please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/viewappearance?cs-save-lang=1&cs-lang=csharp#show-busy-indicator-on-list-view).  


