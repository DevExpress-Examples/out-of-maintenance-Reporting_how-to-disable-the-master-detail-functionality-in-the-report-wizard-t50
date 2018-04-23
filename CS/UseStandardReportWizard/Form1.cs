using System.Windows.Forms;
using DevExpress.XtraReports.Wizards;

namespace UseStandardReportWizard {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            // Replace the default ReportWizardSettings service with a custom one.
            reportDesigner1.RemoveService(typeof(ReportWizardSettings));
            reportDesigner1.AddService(typeof(ReportWizardSettings), new ReportWizardSettings() {
                UseMasterDetailReportWizard = false
            });
        }
    }
}
