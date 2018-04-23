Imports System.Windows.Forms
Imports DevExpress.XtraReports.Wizards

Namespace UseStandardReportWizard
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

            ' Replace the default ReportWizardSettings service with a custom one.
            reportDesigner1.RemoveService(GetType(ReportWizardSettings))
            reportDesigner1.AddService(GetType(ReportWizardSettings), New ReportWizardSettings() With {.UseMasterDetailReportWizard = False})
        End Sub
    End Class
End Namespace
