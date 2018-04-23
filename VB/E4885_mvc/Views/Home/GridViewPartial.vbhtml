@Html.DevExpress().GridView(
    Sub (settings)
            settings.Name = "gridView"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}

            settings.Settings.ShowFilterRow = True
            settings.Settings.ShowFilterRowMenu = True

            settings.Columns.Add(
                Sub(c)
                        c.FieldName = "Col1"
                        CType(c, GridViewDataColumn).FilterCellStyle.CssClass = "necessaryColumn"
                End Sub)
            settings.Columns.Add("Col2")

            settings.Styles.FilterCell.CssClass = "filterCell"
            settings.Styles.FilterRowMenuItem.CssClass = "frmi"
End Sub).Bind(Model).GetHtml()