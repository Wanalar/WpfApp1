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
    CurrentPageControl currentPageControl;

    public Page CurrentPage
    {
        get => currentPageControl.Page;
    }
}
