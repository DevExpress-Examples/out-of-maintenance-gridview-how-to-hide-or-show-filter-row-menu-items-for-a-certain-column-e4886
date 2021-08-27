<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128550102/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4886)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/E4885_mvc/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/E4885_mvc/Controllers/HomeController.vb))
* [GridViewPartial.cshtml](./CS/E4885_mvc/Views/Home/GridViewPartial.cshtml)
* [Index.cshtml](./CS/E4885_mvc/Views/Home/Index.cshtml)
<!-- default file list end -->
# GridView - How to hide or show filter row menu items for a certain column
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4886/)**
<!-- run online end -->


<p>This example demonstrates how to hide or show filter row menu items for a certain column.</p><br />
<p>To do this, we assign CSS classes to:</p><p>- Filter cells using the Styles.FilterCell.CssClass property;</p><p>- Filter row menu items using the Styles.FilterRowMenuItem.CssClass property;</p><p>- Specific column's filter cell using the GridViewDataColumn.FilterCellStyle.CssClass property;</p><br />
<p>These classes will be used later to find the necessary elements:<br />


```js
$().ready(function () {
    $(".filterCell").click(function (event) {
        var hide = $(event.currentTarget).hasClass("necessaryColumn");
        ManageOptions(!hide);
    });
});
function ManageOptions(visible) {
    var value = visible ? "list-item" : "none";
    $(".frmi").each(function () {
        var text = $(this).text().toLowerCase();
        if (text.indexOf("equals") >= 0 || text.indexOf("is less than") >= 0)
            $(this).css("display", value);
    });
}

```

The element's "display" style is changed based on specific conditions.</p>

<br/>


