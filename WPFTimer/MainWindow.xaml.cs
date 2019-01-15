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
using System.Windows.Threading;
using System.Timers;

namespace WPFTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int time = 0;
        private DispatcherTimer Timer;
        
        public MainWindow()
        {
           
            InitializeComponent();
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0,0,1);
            Timer.Tick += Timer_Tick;
            Timer.Start();

          

        }


        void Timer_Tick(object sender, EventArgs e)
        {
            if(time>=0)
            {
                time++;
                tbcount.Text = string.Format("00:0{0}:{1}",time /60, time%60);

            }
            else
            {
                Timer.Stop();
                
            }
        }
    }
}
