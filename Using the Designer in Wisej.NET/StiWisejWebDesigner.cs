using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.AspNetControl;

namespace Using_the_Designer_in_Wisej_NET
{
	[ToolboxItem(true)]
    public class StiWisejWebDesigner : AspNetWrapper<StiWebDesigner>
    {
        #region Properties
        /// <summary>
        /// Returns the Stimulsoft designer instance.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public StiWebDesigner Designer
        {
            get { return this.WrappedControl; }
        }

        public StiReport Report
        {
            get
            {
                return this.Designer.Report;
            }
            set
            {
                if (this.Designer != null) this.Designer.Report = value;
            }
        }
        #endregion

        #region Implementations
        protected override void OnPreInit(EventArgs e)
        {
            // set designer options

            if (this.Designer != null)
            {
                this.Designer.Localization = Application.MapPath("Localization\\en.xml");
                this.Designer.Theme = StiDesignerTheme.Office2022WhiteTeal;

                // attach the handled events to fire the event on the wrapper.

                if (this.GetReport != null)
                    this.Designer.GetReport += this.GetReport;

                if (this.CreateReport != null)
                    this.Designer.CreateReport += this.CreateReport;

                if (this.PreviewReport != null)
                    this.Designer.PreviewReport += this.PreviewReport;

                if (this.SaveReport != null)
                    this.Designer.SaveReport += this.SaveReport;

                if (this.SaveAsReport != null)
                    this.Designer.SaveReportAs += this.SaveAsReport;
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
        public event StiReportDataEventHandler CreateReport;

        /// <summary>
        /// PreviewReport event.
        /// </summary>
        public event StiReportDataEventHandler PreviewReport;

        /// <summary>
        /// SaveReport event.
        /// </summary>
        public event StiSaveReportEventHandler SaveReport;

        /// <summary>
        /// SaveAsReport event.
        /// </summary>
        public event StiSaveReportEventHandler SaveAsReport;
        #endregion
    }
}