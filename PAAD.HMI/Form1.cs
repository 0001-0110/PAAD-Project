using PAAD.BLL.Services;

namespace PAAD.HMI
{
    public partial class Form1 : Form
    {
        IDataService dataService;

        public Form1(IDataService dataService)
        {
            this.dataService = dataService;

            InitializeComponent();
        }
    }
}
