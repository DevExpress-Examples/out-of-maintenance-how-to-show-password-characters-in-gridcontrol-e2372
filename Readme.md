<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653059/11.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2372)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Customer.cs](./CS/WpfApplication1/Customer.cs) (VB: [Customer.vb](./VB/WpfApplication1/Customer.vb))
* **[Window1.xaml](./CS/WpfApplication1/Window1.xaml) (VB: [Window1.xaml.vb](./VB/WpfApplication1/Window1.xaml.vb))**
* [Window1.xaml.cs](./CS/WpfApplication1/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/WpfApplication1/Window1.xaml.vb))
<!-- default file list end -->
# How to show password characters in GridControl


<p>The GridControl itself doesn't provide a way to show password characters in a column. It's necessary to override the CellTemplate property, and use the PasswrodBox in this template. The PasswordBox.Password property can't be bound via xaml - write a helper class to wrap the Password property. In the sample we used the PasswordHelper class from the following thread: <a href="http://www.wpftutorial.net/PasswordBox.html">http://www.wpftutorial.net/PasswordBox.html</a><br /><br /></p>
<p><strong>Edited:</strong><br />Starting from v10.2, the same functionality can be achieved if the corresponding GridColumn's <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfGridColumnBase_EditSettingstopic">EditSettings</a> property is set to <a href="https://documentation.devexpress.com/#wpf/clsDevExpressXpfEditorsSettingsPasswordBoxEditSettingstopic">PasswordBoxEditSettings</a>. Another way is to use the <a href="https://documentation.devexpress.com/#wpf/clsDevExpressXpfEditorsPasswordBoxEdittopic">PasswordBoxEdit</a> control as an editor with the "PART_Editor" name in the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfGridColumnBase_CellTemplatetopic">GridColumn.CellTemplate</a> DataTemplate.</p>

<br/>


