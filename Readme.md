<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/E4885_mvc/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/E4885_mvc/Controllers/HomeController.vb))
* [GridViewPartial.cshtml](./CS/E4885_mvc/Views/Home/GridViewPartial.cshtml)
* [Index.cshtml](./CS/E4885_mvc/Views/Home/Index.cshtml)
<!-- default file list end -->
# GridView - How to hide or show filter row menu items for a certain column


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


