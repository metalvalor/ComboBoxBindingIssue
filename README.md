# Combobox binding issue in ContentControl

### Describe the bug

In a _ContentControl_, when the binded _Content_ changes, the _ComboBox_ _SelectedItem_ in the _DataTemplate_ is set to _NULL_ as well as the binded property in the model.

It happens only when the _DataTemplate_ returned by the _DataTemplateSelector_ remains the same. 

This issue was not present in WPF.

### Steps to reproduce the bug

Clone the [repository](https://github.com/metalvalor/ComboBoxBindingIssue).

Run the project **WinUISample**
1. Click on _Expense 1_ (Category A is selected)
2. Click on _Expense 2_ (Category B is selected)
3. Click on _Expense 1_ (Category is null)

When the _DataTemplate_ changes the category remains
1. Click on _Expense 4_ (Category A is selected)
2. Click on _Expense special_  (Category B is selected, DataTemplate is different)
3. Click on _Expense 4_ (Category A is selected)
4. Selecting _Expense 3_ will set Category to null on _Expense 4_


### Expected behavior

The category need to stay on the right value.

The **WPFSample** included in the solution implementing the same logic works as expected.

### NuGet package version

Windows App SDK 1.4.0: 1.4.230822000

### Windows version

Windows 11 version 22H2 (22621, 2022 Update)

### IDE

Visual Studio 2022
