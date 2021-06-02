﻿using PAF.ViewModel;
using PAF.ViewModel.BaseVM;
using System.Windows.Controls;

namespace PAF.View.Pages
{
    public partial class Component : Page
    {
        public Component(IPage page)
        {
            InitializeComponent();
            this.DataContext = page;
        }
    }
}
