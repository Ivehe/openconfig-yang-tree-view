﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openconfig_yang_tree_view.MVVM.ViewModels
{
    public class TreeViewModel
    {
        public ObservableCollection<GroupingViewModel> Roots { get; } = new ObservableCollection<GroupingViewModel>();
    }
}
