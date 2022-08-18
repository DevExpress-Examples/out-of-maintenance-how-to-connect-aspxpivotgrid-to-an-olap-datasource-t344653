using System;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Customization;
using DevExpress.Web.ASPxPivotGrid;

namespace ASPxOlapRetrieveFieldsExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!IsCallback)
            {
                // Specifies the OLAP connection settings.
                ASPxPivotGrid1.OLAPDataProvider = OLAPDataProvider.Adomd;
                ASPxPivotGrid1.OLAPConnectionString =
                    @"Provider=MSOLAP;
                Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll; 
                Initial catalog=Adventure Works DW Standard Edition;
                Cube name=Adventure Works;
                Query Timeout=100;";

                // Retrieves fields.
                ASPxPivotGrid1.RetrieveFields(PivotArea.ColumnArea, false);

                // Adds some fields from the Field List to the specified area to create a report.
                ASPxPivotGrid1.Fields["[Customer].[Country].[Country]"].Area = PivotArea.RowArea;
                ASPxPivotGrid1.Fields["[Customer].[Country].[Country]"].Visible = true;
                ASPxPivotGrid1.Fields["[Customer].[City].[City]"].Area = PivotArea.RowArea;
                ASPxPivotGrid1.Fields["[Customer].[City].[City]"].Visible = true;
                ASPxPivotGrid1.Fields["[Date].[Fiscal].[Fiscal Year]"].Area = PivotArea.ColumnArea;
                ASPxPivotGrid1.Fields["[Date].[Fiscal].[Fiscal Year]"].Visible = true;
                ASPxPivotGrid1.Fields["[Measures].[Internet Sales Amount]"].Visible = true;

                // Sets the Customization Forms style to Excel2007 with additional capabilities.
                ASPxPivotGrid1.OptionsCustomization.CustomizationFormStyle = CustomizationFormStyle.Excel2007;
            }
        }
    }
}
