﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WVDManagementHub.ViewModel;

namespace WVDManagementHub
{
    /// <summary>
    /// Interaction logic for UserControlMenu.xaml
    /// </summary>
    public partial class UserControlMenu : UserControl
    {
        public UserControlMenu(ItemMenu itemMenu)
        {
            InitializeComponent();


            // This it the dropdown

            ExpanderMenu.Visibility = itemMenu.SubItems == null ? Visibility.Collapsed : Visibility.Visible;
            ListViewItemMenu.Visibility = itemMenu.SubItems == null ? Visibility.Visible : Visibility.Collapsed;

            this.DataContext = itemMenu;



        }
    }
}