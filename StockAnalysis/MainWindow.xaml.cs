using System.Windows;
using System.Windows.Forms;


namespace StockAnalysis
{
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        private void BtnFileSelect_Click(object sender, RoutedEventArgs e) {

            var fileDialog = new OpenFileDialog();
            var result = fileDialog.ShowDialog();

            switch (result) {
                case System.Windows.Forms.DialogResult.OK:
                    var file = fileDialog.FileName;
                    TxtBlkFIleSelect.Text = file;
                    TxtBlkFIleSelect.ToolTip = "Directory of PDFs for analysis";
                    break;
                case System.Windows.Forms.DialogResult.Cancel:
                default:
                    TxtBlkFIleSelect.Text = null;
                    TxtBlkFIleSelect.ToolTip = null;
                    break;
            }
        }
    }
}
