using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DTO;
using WpfApp1.Model;
using WpfApp1.Tools;

namespace WpfApp1.ViewModels
{
    public class EditWorkVM
    {

        public Work EditWork { get; set; }
        public CommandVM SaveAcademic_plan { get; set; }

        private CurrentPageControl currentPageControl;
        public EditWorkVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditWork = new Work();
            InitCommand();
        }
        public EditWorkVM(Work editWork, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditWork = editWork;
            InitCommand();
        }

        private void InitCommand()
        {
            SaveAcademic_plan = new CommandVM(() =>
            {
                var model = SqlModel.GetInstance();
                if (EditWork.ID == 0)
                    model.Insert(EditWork);
                else
                    model.Update(EditWork);
                currentPageControl.Back();
            });
        }

    }
}