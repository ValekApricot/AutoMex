﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace AutoMex.Pages
{
    /// <summary>
    /// Логика взаимодействия для pgProvider.xaml
    /// </summary>
    public partial class pgProvider : Page
    {
        public pgProvider()
        {
            InitializeComponent();
            DG.ItemsSource = Context.Provider.ToList();
        }
        private void DG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextBlock x = DG.Columns[0].GetCellContent(DG.Items[DG.SelectedIndex]) as TextBlock;
            IDChange = Convert.ToInt32(x?.Text);
        }

        private void CB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CB.SelectedIndex)
            {
                case 0:
                    DG.ItemsSource = Context.Provider.ToList().Where(i => i.IDProvider == Convert.ToInt32(tbSearch.Text));
                    break;
                case 1:
                    DG.ItemsSource = Context.Provider.ToList().Where(i => i.Name == tbSearch.Text);
                    break;
            }
        }

        private void btnAll_Click(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = Context.Provider.ToList();
        }
    }
}
