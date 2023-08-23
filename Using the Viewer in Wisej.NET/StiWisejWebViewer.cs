using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.AspNetControl;

namespace Using_the_Viewer_in_Wisej_NET
{
	[ToolboxItem(true)]
    public class StiWisejWebViewer : AspNetWrapper<StiWebViewer>
    {
        #region Properties
        /// <summary>
        /// Returns the Stimulsoft designer instance.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public StiWebViewer Viewer
        {
            get { return this.WrappedControl; }
        }

        public StiReport Report
        {
            get
            {
                return this.Viewer.Report;
            }
            set
            {
                this.Viewer.Report = value;
            }
        }
        #endregion

        #region Implementations
        protected override void OnPreInit(EventArgs e)
        {
            // set viewer options
            if (this.Viewer != null)
            {
                this.Viewer.Localization = Application.MapPath("Localization\\en.xml");
                this.Viewer.Theme = StiViewerTheme.Office2022BlackOrange;
                this.Viewer.FullScreenMode = true;

                // attach the handled events to fire the event on the wrapper.

                if (this.GetReport != null)
                    this.Viewer.GetReport += this.GetReport;

                if (this.PrintReport != null)
                    this.Viewer.PrintReport += this.PrintReport;

                if (this.ExportReport != null)
                    this.Viewer.ExportReport += this.ExportReport;

                if (this.Interaction != null)
                    this.Viewer.Interaction += this.Interaction;
            }

            base.OnPreInit(e);
        }
        #endregion

        #region Events
        /// <summary>
        /// LoadReport event.
        /// </summary>
        public event StiReportDataEventHandler GetReport;

        /// <summary>
        /// CreateReport event.
        /// </summary>
        public event StiPrintReportEventHandler PrintReport;

        /// <summary>
        /// PreviewReport event.
        /// </summary>
        public event StiExportReportEventHandler ExportReport;

        /// <summary>
        /// SaveReport event.
        /// </summary>
        public event StiReportDataEventHandler Interaction;
        #endregion
    }
}