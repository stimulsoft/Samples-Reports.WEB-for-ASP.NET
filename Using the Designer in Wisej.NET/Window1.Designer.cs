using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using Wisej.Web;

namespace Using_the_Designer_in_Wisej_NET
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

        #region Wisej Designer generated code

        private StiWisejWebDesigner wisejWebDesigner;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            wisejWebDesigner = new Using_the_Designer_in_Wisej_NET.StiWisejWebDesigner();
            this.SuspendLayout();

            // 
            // WisejWebDesigner
            // 
            wisejWebDesigner.Dock = Wisej.Web.DockStyle.Fill;
            wisejWebDesigner.Location = new System.Drawing.Point(0, 0);
            wisejWebDesigner.Name = "wisejWebDesigner";
            wisejWebDesigner.Size = new System.Drawing.Size(1200, 800);
            wisejWebDesigner.TabIndex = 0;
            wisejWebDesigner.Text = "wisejWebDesigner";

            //set designer events
            wisejWebDesigner.GetReport += new StiReportDataEventHandler(this.WisejWebDesigner_GetReport);
            wisejWebDesigner.PreviewReport += new StiReportDataEventHandler(this.WisejWebDesigner_Preview);
            wisejWebDesigner.SaveReport += new StiSaveReportEventHandler(this.WisejWebDesigner_Save);
            wisejWebDesigner.CreateReport += new StiReportDataEventHandler(this.WisejWebDesigner_Create);

            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 9F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(wisejWebDesigner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        #region Wisej Designer events
        private void WisejWebDesigner_GetReport(object sender, StiReportDataEventArgs e)
        {
            var reportFilePath = Application.MapPath("Reports\\SimpleList.mrt");
            var report = new StiReport();
            report.Load(reportFilePath);
            this.wisejWebDesigner.Report = report;
        }

        private void WisejWebDesigner_Save(object sender, StiSaveReportEventArgs e)
        {
            var fileName = e.FileName ?? "Report.mrt";
            e.Report.Save(Application.MapPath($"Reports\\{fileName}"));
        }

        private void WisejWebDesigner_Create(object sender, StiReportDataEventArgs e)
        {
            var data = new DataSet("Demo");
            data.ReadXml(Application.MapPath(("Data\\Demo.xml")));

            e.Report.RegData(data);
            e.Report.Dictionary.Synchronize();
        }

        private void WisejWebDesigner_Preview(object sender, StiReportDataEventArgs e)
        {

        }
        #endregion
    }
}

