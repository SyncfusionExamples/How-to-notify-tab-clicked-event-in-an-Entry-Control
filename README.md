# How to handle Tab Key press event in an Entry control on the windows platform
In this article, we will show you how to handle Tab key press event in an Entry control on the Windows platform within a [.Net Maui DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid). 

## Xaml 
```
 <syncfusion:SfDataGrid x:Name="dataGrid"
                        ItemsSource="{Binding Employees}"
                        GridLinesVisibility="Both"
                        HeaderGridLinesVisibility="Both"
                        ColumnWidthMode="Auto"
                        AutoGenerateColumnsMode="None">


     <syncfusion:SfDataGrid.Columns>
         <syncfusion:DataGridTextColumn MappingName="EmployeeID"
                                        Format="#" />
         <syncfusion:DataGridTextColumn MappingName="Name" />
         <syncfusion:DataGridTextColumn MappingName="Title" />
         <syncfusion:DataGridDateColumn MappingName="HireDate" />
         <syncfusion:DataGridTemplateColumn MappingName="Name"
                                            HeaderText="Customer Name">
             <syncfusion:DataGridTemplateColumn.CellTemplate>
                 <DataTemplate>
                     <Entry HandlerChanged="Entry_HandlerChanged"
                            Placeholder="Enter Name" />
                 </DataTemplate>
             </syncfusion:DataGridTemplateColumn.CellTemplate>
         </syncfusion:DataGridTemplateColumn>
     </syncfusion:SfDataGrid.Columns>

 </syncfusion:SfDataGrid>
```

## C#
The below code illustrates how to handle Tab key press event in an Entry control on the Windows platform within a DataGrid.
```
        private void Entry_HandlerChanged(object sender, EventArgs e)
        {
#if WINDOWS
            if (sender is Entry entry && entry.Handler?.PlatformView is Microsoft.Maui.Platform.MauiPasswordTextBox textBox)
            {
                textBox.KeyDown += TextBox_KeyDown;
            }
#endif
        }

#if WINDOWS 
        private void TextBox_KeyDown(object sender, Microsoft.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Tab) 
            {
                DisplayAlert("Tab Pressed", "The Tab key was pressed", "OK");
            }

        }
#endif
```
 ![TabDemo.gif](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI4NjIzIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.S0vc20nEaLh-YY2m_HwADEA5A7DVY_x3cDzISvBw4Pc)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-notify-tab-clicked-event-in-an-Entry-Control)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to handle Tab key press event in an Entry control on the Windows platform within .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!