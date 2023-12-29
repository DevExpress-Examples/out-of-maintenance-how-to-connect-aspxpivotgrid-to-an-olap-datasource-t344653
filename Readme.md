<!-- default file list -->
*Files to look at*:

* [WebForm1.aspx](./CS/ASPxOlapRetrieveFieldsExample/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/ASPxOlapRetrieveFieldsExample/WebForm1.aspx))
* [WebForm1.aspx.cs](./CS/ASPxOlapRetrieveFieldsExample/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/ASPxOlapRetrieveFieldsExample/WebForm1.aspx.vb))
<!-- default file list end -->
# How to connect ASPxPivotGrid to an OLAP datasource


If you have a cube on the OLAP server (Microsoft Analysis Services), you can view its data using the <a href="https://documentation.devexpress.com/AspNet/CustomDocument5830.aspx">ASPxPivotGrid control</a>. In this example, you will see how to specify connection settings to the server and create fields that represents specific measures and dimensions of the cube.<br><br>To bind the Pivot Grid control to an OLAP cube, follow the steps below.<br><br>1. Set <em>ADOMD</em> as a data provider using the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxPivotGridASPxPivotGrid_OLAPDataProvidertopic">ASPxPivotGrid.OLAPDataProvider</a> property.<br>2. Specify connection settings to the server using the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxPivotGridASPxPivotGrid_OLAPConnectionStringtopic">ASPxPivotGrid.OLAPConnectionString</a> property. The connection string used in the example is shown below.<br><em>OlapConnectionString="Provider=MSOLAP;Data Source=<a href="http://demos.devexpress.com/Services/OLAP/msmdpump.dll;Initial">http://demos.devexpress.com/Services/OLAP/msmdpump.dll;Initial</a> catalog=Adventure Works DW Standard Edition;Cube name=Adventure Works;Query Timeout=100;"</em><br>3. Create fields for all the measures and dimension in the bound OLAP cube, and moves these fields to the specified area, making them hidden. To do it, use the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxPivotGridASPxPivotGrid_RetrieveFieldstopic(w5D4CA)">ASPxPivotGrid.RetrieveFields</a> method overload and set the field's visibility to <strong>false</strong>.<br>4. Place some of the created fields within corresponding Pivot Grid Control areas and set the visibility of the fields to <strong>true </strong>using the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldBase_Visibletopic">PivotGridFieldBase.Visible</a> property.<br><br>Use the invoked <a href="https://documentation.devexpress.com/#AspNet/CustomDocument7265">Customization Form</a> to specify the Pivot Grid control's layout.<br><br>To learn more, see <a href="https://documentation.devexpress.com/#AspNet/CustomDocument11779">OLAP Datasources</a>.

<br/>


