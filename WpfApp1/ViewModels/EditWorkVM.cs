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
    public class EditWorkVM : BaseVM
    {
       
            public Work EditWork { get; set; }
            public CommandVM SaveWork { get; set; }
            

        public Discipline DisciplineAcademic_plan
        {
            get => disciplineAcademic_plan;
            set
            {
                disciplineAcademic_plan = value;
                Signal();
            }
        }

        public List<Discipline> Disciplines { get; set; }
        private Discipline disciplineAcademic_plan;

        public CommandVM Work { get; private set; }

        private CurrentPageControl currentPageControl;
            public EditWorkVM(CurrentPageControl currentPageControl)
            {
                this.currentPageControl = currentPageControl;
                EditWork = new Work();
                InitCommand();
            }
         
            
            private void InitCommand()
            {
            Work = new CommandVM(() => {
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