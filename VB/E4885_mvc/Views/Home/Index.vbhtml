@Code
    ViewBag.Title = "Home Page"
End Code

<script type="text/javascript">
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
</script>

@Html.Action("GridViewPartial")