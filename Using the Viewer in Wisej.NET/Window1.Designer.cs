using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using Wisej.Web;

namespace Using_the_Viewer_in_Wisej_NET
{
	partial class Window1
{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Wisej.NET Designer generated code

        private StiWisejWebViewer wisejWebViewer;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
		{
            wisejWebViewer = new Using_the_Viewer_in_Wisej_NET.StiWisejWebViewer();
            this.SuspendLayout();

            wisejWebViewer.Dock = Wisej.Web.DockStyle.Fill;
            wisejWebViewer.Location = new System.Drawing.Point(0, 0);
            wisejWebViewer.Name = "wisejWebViewer";
            wisejWebViewer.Size = new System.Drawing.Size(1200, 800);
            wisejWebViewer.TabIndex = 0;
            wisejWebViewer.Text = "wisejWebViewer";

            //set viewer events
            wisejWebViewer.GetReport += new StiReportDataEventHandler(this.WisejWebViewer_GetReport);
            wisejWebViewer.PrintReport += new StiPrintReportEventHandler(this.WisejWebViewer_PrintReport);
            wisejWebViewer.ExportReport += new StiExportReportEventHandler(this.WisejWebViewer_ExportReport);
            wisejWebViewer.Interaction += new StiReportDataEventHandler(this.WisejWebViewer_Interaction);

            //wisejWebViewer.PreviewReport += new StiReportDataEventHandler(this.WisejWebDesigner_Preview);
            //wisejWebViewer.SaveReport += new StiSaveReportEventHandler(this.WisejWebDesigner_Save);
            //wisejWebViewer.CreateReport += new StiReportDataEventHandler(this.WisejWebDesigner_Create);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 9F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(wisejWebViewer);
            this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
        #endregion

        #region Wisej Viewer events
        private void WisejWebViewer_GetReport(object sender, StiReportDataEventArgs e)
        {
            var reportFilePath = Application.MapPath("Reports\\SimpleList.mrt");
            var report = new StiReport();
            report.Load(reportFilePath);
            this.wisejWebViewer.Report = report;
        }

        private void WisejWebViewer_PrintReport(object sender, StiPrintReportEventArgs e)
        {
           
        }

        private void WisejWebViewer_ExportReport(object sender, StiExportReportEventArgs e)
        {

        }

        private void WisejWebViewer_Interaction(object sender, StiReportDataEventArgs e)
        {

        }
        #endregion
    }
}

