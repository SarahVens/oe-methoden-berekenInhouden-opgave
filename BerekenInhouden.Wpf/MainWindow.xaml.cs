using System;
using System.Windows;

namespace BerekenInhouden.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variabelen
        #region Variabelen
        const double Getal_Pi = Math.PI;
        #endregion
        //Methoden
        #region Methoden
        void WijzigZichtbaarheidGrid(Visibility zichtbaarheid)
        {
            grdCilinder.Visibility = zichtbaarheid;
            grdBalk.Visibility = zichtbaarheid;
            grdHoogte.Visibility = zichtbaarheid;
        }
        void ToonGrid(Visibility BalkGrid, Visibility CilinderGrid)
        {
            grdBalk.Visibility = BalkGrid;
            grdCilinder.Visibility = CilinderGrid;
            grdHoogte.Visibility = Visibility.Visible;

            
        }

        void WisInputEnBerekeningen()
        {
            txtBreedte.Text = "";
            txtHoogte.Text = "";
            txtLengte.Text = "";
            txtDiameter.Text = "";
            tbkBerekeningBalk.Text = "";
            tbkBerekeningCilinder.Text = "";
        }

        int GeefInhoudBalk(int lengte, int breedte, int hoogte)
        {
            int inhoudBalk;
            inhoudBalk = lengte * breedte * hoogte;
            return inhoudBalk;
        }

        float GeefInhoudCilinder(int hoogte, double diameter)
        {
            double inhoudCilinder;
            inhoudCilinder = Convert.ToSingle(Getal_Pi) * hoogte * Math.Sqrt(diameter/2);
            return Convert.ToSingle(inhoudCilinder);
        }
        #endregion
        public MainWindow()
        {
            InitializeComponent();

        }


        //Event Handelers
        #region EventHandelers

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WijzigZichtbaarheidGrid(Visibility.Hidden);
        }



        private void btnBalk_Click(object sender, RoutedEventArgs e)
        {
            Visibility toonBalk = Visibility.Visible;
            Visibility toonCilinder = Visibility.Hidden;
            ToonGrid(toonBalk, toonCilinder);
            WisInputEnBerekeningen();
        }

               

        private void btnCilinder_Click(object sender, RoutedEventArgs e)
        {
            Visibility toonBalk = Visibility.Hidden;
            Visibility toonCilinder = Visibility.Visible;
            grdCilinder.Margin = new Thickness(10, 133, 0, 0);
            ToonGrid(toonBalk, toonCilinder);
            WisInputEnBerekeningen();
        }



        private void btnBerekenBalk_Click(object sender, RoutedEventArgs e)
        {
            int lengte = int.Parse(txtLengte.Text);
            int breedte = int.Parse(txtBreedte.Text);
            int hoogte = int.Parse(txtHoogte.Text);
            int inhoudbalk = GeefInhoudBalk(lengte, breedte, hoogte);
            tbkBerekeningBalk.Text = $"{lengte.ToString()} * {breedte.ToString()} * {hoogte.ToString()} = {inhoudbalk.ToString()}";
        }
    

        private void btnBerekenCilinder_Click(object sender, RoutedEventArgs e)
        {
            int hoogte = int.Parse(txtHoogte.Text);
            double diameter = double.Parse(txtDiameter.Text);
            float inhoudCilinder = GeefInhoudCilinder(hoogte, diameter);
            tbkBerekeningCilinder.Text = $"{hoogte.ToString()} * ({diameter.ToString()}/2)2 * {Getal_Pi.ToString("0.00")} = {inhoudCilinder.ToString("00.00")}";
        }   
        #endregion
    } 
}
