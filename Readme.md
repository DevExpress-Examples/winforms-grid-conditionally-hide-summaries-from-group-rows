<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128626318/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1354)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - Show/hide summaries in group rows based on a specific condition

This example handles the [CustomDrawGroupRow](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.CustomDrawGroupRow) event to update text in group rows (show/hide certain summaries) based on a condition. The Max summary is displayed for group rows where Discontinued is True. The Min summary is displayed in rows with Discontinued set to False.


## Files to Review

* [Form1.cs](./CS/ConditionallyHideSumsInGroupRows/Form1.cs) (VB: [Form1.vb](./VB/ConditionallyHideSumsInGroupRows/Form1.vb))


## Documentation

* [Working with Summaries in Code - Custom Summaries](https://docs.devexpress.com/WindowsForms/701/controls-and-libraries/data-grid/summaries/working-with-summaries-in-code-custom-summaries)
* [Custom Painting Basics](https://docs.devexpress.com/WindowsForms/762/controls-and-libraries/data-grid/appearance-and-conditional-formatting/custom-painting/custom-painting-basics)
