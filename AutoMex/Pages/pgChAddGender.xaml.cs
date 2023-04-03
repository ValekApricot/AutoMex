﻿using AutoMex.DateBase;
using System;
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
    /// Логика взаимодействия для pgChAddGender.xaml
    /// </summary>
    public partial class pgChAddGender : Page
    {
        public pgChAddGender()
        {
            InitializeComponent();

            if (Change == true)
            {
                Change = false;

                tbID.Text = Context.Gender.ToList().Where(i => i.IDGender == IDChange).FirstOrDefault().IDGender.ToString();
                tbName.Text = Context.Gender.ToList().Where(i => i.IDGender == IDChange).FirstOrDefault().Name;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Gender g = new Gender();

            g.IDGender = Convert.ToInt32(tbID.Text);
            g.Name = tbName.Text;

            Context.Gender.AddOrUpdate(g);
            Context.SaveChanges();
            MessageBox.Show("Successfully");
        }
    }
}
