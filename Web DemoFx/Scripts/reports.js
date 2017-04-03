function buildReportTree()
{
    dm = new dTree('dm');

    // Categories
    dm.add(0, -1, '');
    dm.add(1, 0, 'Basic Reports', null, null, null, null, null, true);
    dm.add(2, 0, 'Reports with Columns');
    dm.add(3, 0, 'Master-Detail Reports');
    dm.add(4, 0, 'Reports with Groups');
    dm.add(5, 0, 'Hierarchical Reports');
    dm.add(6, 0, 'Interactive Reports');
    dm.add(7, 0, 'Parameters');
    dm.add(8, 0, 'Charts');
    dm.add(9, 0, 'Cross-Tabs Reports');
    dm.add(10, 0, 'Reports with EmptyBand');
    dm.add(11, 0, 'Containers');
    dm.add(12, 0, 'SubReports');

    // Basic Reports
    dm.add(101, 1, 'Simple List', '?reportname=SimpleList');
    dm.add(102, 1, 'Two Simple Lists', '?reportname=TwoSimpleLists');
    dm.add(103, 1, 'Highlight Condition', '?reportname=HighlightCondition');
    dm.add(104, 1, 'Shapes', '?reportname=Shapes');
    dm.add(105, 1, 'Images', '?reportname=Images');
    dm.add(106, 1, 'RichText', '?reportname=RichText');
    dm.add(107, 1, 'Watermark', '?reportname=Watermark');
    dm.add(108, 1, 'Bar-Codes', '?reportname=BarCodes');
    dm.add(109, 1, 'Invoice', '?reportname=Invoice');
    dm.add(110, 1, 'Indicators', '?reportname=Indicators');
    
    // Reports with Columns
    dm.add(201, 2, 'Multi-Column List', '?reportname=MultiColumnList');
    dm.add(202, 2, 'Multi-Column Bands, Across-Down', '?reportname=MultiColumnBandsAcrossThenDown');
    dm.add(203, 2, 'Multi-Column Bands, Down-Across', '?reportname=MultiColumnBandsDownThenAcross');
    dm.add(204, 2, 'Labels', '?reportname=Labels');
    
    // Master-Detail Reports
	dm.add(301, 3, 'Master-Detail', '?reportname=MasterDetail');
	dm.add(302, 3, 'Master-Detail-Subdetail', '?reportname=MasterDetailSubdetail');
	dm.add(303, 3, 'Master-Detail with Columns', '?reportname=MasterDetailWithColumns');
    dm.add(304, 3, 'Two Masters on One Detail', '?reportname=TwoMastersOnOneDetail');
    dm.add(305, 3, 'Master-Detail with zero Height', '?reportname=MasterDetailWithZeroHeight');
    dm.add(306, 3, 'Master-Detail on DataBand', '?reportname=MasterDetailOnDataBand');
    
    // Reports with Groups
    dm.add(401, 4, 'Simple Group', '?reportname=SimpleGroup');
    dm.add(402, 4, 'Nested Groups', '?reportname=NestedGroups');
    dm.add(403, 4, 'Top Sales', '?reportname=GroupsTopSales');
    dm.add(404, 4, 'Master-Detail with Groups', '?reportname=MasterDetailWithGroups');
    dm.add(405, 4, 'Multi-Column Group', '?reportname=MultiColumnGroup');
    dm.add(406, 4, 'Groups with Ranges', '?reportname=GroupsWithRanges');
    dm.add(407, 4, 'Simple Group with Columns', '?reportname=SimpleGroupWithColumns');
    dm.add(408, 4, 'All Group Footers at End', '?reportname=AllGroupFootersAtEnd');
    dm.add(409, 4, 'Invoice with Groups', '?reportname=InvoiceWithGroups');
    dm.add(410, 4, 'Sales Invoice', '?reportname=SalesInvoice');
    
    // Hierarchical Reports
    dm.add(501, 5, 'Tree', '?reportname=Tree');
    dm.add(502, 5, 'Tree with Headers and Footers', '?reportname=TreeWithHeadersFooters');
    dm.add(503, 5, 'Tree with Totals', '?reportname=TreeWithTotals');
    dm.add(504, 5, 'Tree with Totals, All Levels', '?reportname=TreeWithTotalsAllLevels');
    dm.add(505, 5, 'Tree with Locked Components', '?reportname=TreeWithLockedComponents');
    
    // Interactive Reports
    dm.add(601, 6, 'Interactive Sorting', '?reportname=DrillDownSorting');
    
    // Parameters
    dm.add(701, 7, 'Detailed Categories', '?reportname=ParametersDetailedCategories');
    dm.add(702, 7, 'Detailed Orders', '?reportname=ParametersDetailedOrders');
    dm.add(703, 7, 'Highlight Condition', '?reportname=ParametersHighlightCondition');
    dm.add(704, 7, 'Selecting Country', '?reportname=ParametersSelectingCountry');
    dm.add(705, 7, 'Invoice', '?reportname=ParametersInvoice');
    
    // Charts
    dm.add(801, 8, 'Population', '?reportname=ChartPopulation');
    dm.add(802, 8, 'GDP Growth 2005-2010', '?reportname=ChartGDPGrowth20052010');
    dm.add(803, 8, 'Global Growth 2006 and 2008', '?reportname=ChartGlobalGrowth20062008');
    dm.add(804, 8, 'Global Growth 2008', '?reportname=ChartGlobalGrowth2008');
    dm.add(805, 8, 'Migration by Decade in USA', '?reportname=ChartMigrationByDecadeInUSA');
    dm.add(806, 8, 'Foreign official reserves in Euro', '?reportname=ChartForeignOfficialReservesInEuro');
    dm.add(807, 8, 'Oil Extraction by Countries', '?reportname=ChartOilExtractionByCountries');
    dm.add(808, 8, 'Produced Cars', '?reportname=ChartProducedCars');
    dm.add(809, 8, 'Chart Styles', '?reportname=ChartStyles');
    dm.add(810, 8, 'Chart on DataBand', '?reportname=ChartOnDataBand');
    
    // Cross-Tabs Reports
    dm.add(901, 9, 'Standard Cross-Tab', '?reportname=StandardCrossTab');
    dm.add(902, 9, 'Cross-Tab without Columns', '?reportname=CrossTabWithoutColumns');
    dm.add(903, 9, 'Cross-Tab without Rows', '?reportname=CrossTabWithoutRows');
    dm.add(904, 9, 'Cross-Tab with Highlight Condition', '?reportname=CrossTabWithHighlightCondition');
    dm.add(905, 9, 'Cross-Tab with Two Summaries', '?reportname=CrossTabWithTwoSummaries');
    dm.add(906, 9, 'Two Cross-Tabs', '?reportname=TwoCrossTabs');
    dm.add(907, 9, 'Wrapped Cross-Tabs', '?reportname=WrappedCrossTab');
    dm.add(908, 9, 'Large Cross-Tab', '?reportname=LargeCrossTab');
    dm.add(909, 9, 'Cross-Tab on DataBand', '?reportname=CrossTabOnDataBand');
    
    // Reports with EmptyBand
    dm.add(1001, 10, 'Simple List with Empty Lines', '?reportname=SimpleListWithEmptyLines');
    dm.add(1002, 10, 'Master-Detail with Empty Lines', '?reportname=MasterDetailWithEmptyLines');
    dm.add(1003, 10, 'Invoice with Empty Band', '?reportname=InvoiceWithEmptyBand');
    
    // Containers
    dm.add(1101, 11, 'Side by Side List', '?reportname=SideBySideListWithContainers');
    dm.add(1102, 11, 'Side by Side Group', '?reportname=SideBySideGroupWithContainers');
    dm.add(1103, 11, 'Multi-Column List', '?reportname=MultiColumnListContainers');
    dm.add(1104, 11, 'Multi-Containers', '?reportname=MultiContainers');
    dm.add(1105, 11, 'Master-Detail Cards', '?reportname=MasterDetailCards');
    
    // SubReports
    dm.add(1201, 12, 'Side by Side List', '?reportname=SideBySideListWithSubReports');
    dm.add(1202, 12, 'Side by Side List on DataBand', '?reportname=SideBySideListWithSubReportsOnDataBand');
    dm.add(1203, 12, 'Side by Side Group', '?reportname=SideBySideGroupWithSubReports');
    dm.add(1204, 12, 'Master-Detail', '?reportname=MasterDetailWithSubReports');
    
    document.write(dm);
}