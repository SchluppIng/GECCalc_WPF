using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;
using System.Reflection;
using System.IO;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Drawing;
using System.Resources;
//Set Version of G.E.C. Calc
[assembly: AssemblyVersion("1.0.0.0")]

namespace GECCalc_WPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool formLoaded = false;
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void closeToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, RoutedEventArgs e)
        {
            //this.Text = "G.E.C. Calc Version " + typeof(MainForm).Assembly.GetName().Version;

            //MessageBox.Show("Läuft");
            //Das ist mal fürn arsch.
            richTxtResults.Document.Blocks.Add(new Paragraph(new Run("Läuft")));
            txtConfigurationName.Text = "Ich kann hier schreiben";
            MessageBox.Show(txtConfigurationName.Text + " und auch das geschriebene lesen.");
        }

        private void comboBoxColumnGrid_SelectedValueChanged(object sender, SelectionChangedEventArgs e)
        {
            BitmapImage bi = new BitmapImage();
            
            if (comboBoxColumnGrid.SelectedIndex == 0 && formLoaded == true)
            {
                bi.BeginInit();
                bi.UriSource = new Uri("Rectangle.png", UriKind.Relative);
                bi.EndInit();
                imageBox.Source = bi;
                lblGridSelected.Content = "Rectangle grid selected";
            }
            else if (comboBoxColumnGrid.SelectedIndex == 1 && formLoaded == true)
            {
                bi.BeginInit();
                bi.UriSource = new Uri("Quadratic.png", UriKind.Relative);
                bi.EndInit();
                imageBox.Source = bi;
                lblGridSelected.Content = "Quadratic grid selected";
            }
            formLoaded = true;
        }
    }
}
