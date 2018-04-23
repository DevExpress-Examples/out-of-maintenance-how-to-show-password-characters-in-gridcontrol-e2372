# How to show password characters in GridControl


<p>The GridControl itself doesn't provide a way to show password characters in a column. It's necessary to override the CellTemplate property, and use the PasswrodBox in this template. The PasswordBox.Password property can't be bound via xaml - write a helper class to wrap the Password property. In the sample we used the PasswordHelper class from the following thread: <a href="http://www.wpftutorial.net/PasswordBox.html">http://www.wpftutorial.net/PasswordBox.html</a><br /><br /></p>
<p><strong>Edited:</strong><br />Starting from v10.2, the same functionality can be achieved if the corresponding GridColumn's <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfGridColumnBase_EditSettingstopic">EditSettings</a> property is set to <a href="https://documentation.devexpress.com/#wpf/clsDevExpressXpfEditorsSettingsPasswordBoxEditSettingstopic">PasswordBoxEditSettings</a>. Another way is to use the <a href="https://documentation.devexpress.com/#wpf/clsDevExpressXpfEditorsPasswordBoxEdittopic">PasswordBoxEdit</a> control as an editor with the "PART_Editor" name in the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfGridColumnBase_CellTemplatetopic">GridColumn.CellTemplate</a> DataTemplate.</p>

<br/>


