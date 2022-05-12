using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp1.Pages;
using WpfApp1.Tools;

namespace WpfApp1.ViewModels
{
    class MainVM : BaseVM
    {
        CurrentPageControl currentPageControl;

        public Page CurrentPage
        {
            get => currentPageControl.Page;
        }
        
        public CommandVM CreateWork{ get; set; }
        public CommandVM ViewWork{ get; set; }
        public CommandVM CreateAcademic_plan{ get; set; }
        public CommandVM ViewAcademic_plan { get; set; }
        public CommandVM DownloudPage  { get; set; }

        public CommandVM Connection { get; set; }
        public MainVM()
        {
            currentPageControl = new CurrentPageControl();
            currentPageControl.PageChanged += CurrentPageControl_PageChanged;

            CreateWork = new CommandVM(() => {
                currentPageControl.SetPage(new EditWorkPage(new EditWorkVM(currentPageControl)));
            });
            ViewWork = new CommandVM(() => {
                currentPageControl.SetPage(new ViewWorksVM());
            });
            CreateAcademic_plan = new CommandVM(() => {
                currentPageControl.SetPage(new EditAcademic_planPage(new EditAcademic_planVM(currentPageControl)));
            });
            ViewAcademic_plan = new CommandVM(() => {
                currentPageControl.SetPage(new ViewAcademic_plansVM());
            });

            Connection = new CommandVM(() => {
                currentPageControl.SetPage(new Option(currentPageControl));
            });



        }
        private void CurrentPageControl_PageChanged(object sender, EventArgs e)
        {
            Signal(nameof(CurrentPage));
        }
    }
}
