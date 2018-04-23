Imports System
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Customization
Imports DevExpress.Web.ASPxPivotGrid

Namespace ASPxOlapRetrieveFieldsExample
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

            ' Specifies the OLAP connection settings.
            ASPxPivotGrid1.OLAPDataProvider = OLAPDataProvider.Adomd
            ASPxPivotGrid1.OLAPConnectionString = "Provider=MSOLAP;" & ControlChars.CrLf & _
"                Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll; " & ControlChars.CrLf & _
"                Initial catalog=Adventure Works DW Standard Edition;" & ControlChars.CrLf & _
"                Cube name=Adventure Works;" & ControlChars.CrLf & _
"                Query Timeout=100;"

            ' Retrieves fields.
            ASPxPivotGrid1.RetrieveFields(PivotArea.ColumnArea, False)

            ' Adds some fields from the Field List to the specified area to create a report.
            ASPxPivotGrid1.Fields("[Customer].[Country].[Country]").Area = PivotArea.RowArea
            ASPxPivotGrid1.Fields("[Customer].[Country].[Country]").Visible = True
            ASPxPivotGrid1.Fields("[Customer].[City].[City]").Area = PivotArea.RowArea
            ASPxPivotGrid1.Fields("[Customer].[City].[City]").Visible = True
            ASPxPivotGrid1.Fields("[Date].[Fiscal].[Fiscal Year]").Area = PivotArea.ColumnArea
            ASPxPivotGrid1.Fields("[Date].[Fiscal].[Fiscal Year]").Visible = True
            ASPxPivotGrid1.Fields("[Measures].[Internet Sales Amount]").Visible = True

            ' Sets the Customization Forms style to Excel2007 with additional capabilities.
            ASPxPivotGrid1.OptionsCustomization.CustomizationFormStyle = CustomizationFormStyle.Excel2007

        End Sub
    End Class
End Namespace