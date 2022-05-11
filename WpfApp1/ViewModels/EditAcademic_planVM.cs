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
    public class EditAcademic_planVM
    {
        public Academic_plan EditAcademic_plan { get; set; }
        public CommandVM SaveAcademic_plan { get; set; }

        private CurrentPageControl currentPageControl;
        public EditAcademic_planVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditAcademic_plan = new Academic_plan();
            InitCommand();
        }
        public EditAcademic_planVM(Academic_plan editAcademic_plan, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            EditAcademic_plan = editAcademic_plan;
            InitCommand();
        }

        private void InitCommand()
        {
            SaveAcademic_plan = new CommandVM(()=> {
                var model = SqlModel.GetInstance();
                if (EditAcademic_plan.ID == 0)
                    model.Insert(EditAcademic_plan);
                else
                    model.Update(EditAcademic_plan);
                currentPageControl.Back();
            });
        }

        

    }
}
