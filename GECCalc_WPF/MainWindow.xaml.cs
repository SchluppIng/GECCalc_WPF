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
//Set Version of G.E.C. Calc
[assembly: AssemblyVersion("1.0.0.0")]

namespace GECCalc_WPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
            //Set Chars of Text to indices
            //charOffsets();
            MessageBox.Show("Läuft");
            txtConfigurationName.Text = "Ich kann hier schreiben";
            MessageBox.Show(txtConfigurationName.Text + " und auch das geschriebene lesen.");
        }

        //Set offsets for Chars in Richtextbox
        #region Set offsets for text
        //public void charOffsets()
        //{
        //    richTextBoxColumRadius.SelectionStart = 14;
        //    richTextBoxColumRadius.SelectionLength = "c".Length;
        //    richTextBoxColumRadius.SelectionCharOffset = -5;

        //    richTextBoxWideningActivation.SelectionStart = 21;
        //    richTextBoxWideningActivation.SelectionLength = "geo".Length;
        //    richTextBoxWideningActivation.SelectionCharOffset = -5;

        //    richTextBoxLoad.SelectionStart = 7;
        //    richTextBoxLoad.SelectionLength = "d".Length;
        //    richTextBoxLoad.SelectionCharOffset = -5;
        //    richTextBoxLoad.SelectionStart = 12;
        //    richTextBoxLoad.SelectionLength = "d".Length;
        //    richTextBoxLoad.SelectionCharOffset = -5;
        //    richTextBoxLoad.SelectionStart = 16;
        //    richTextBoxLoad.SelectionLength = "0".Length;
        //    richTextBoxLoad.SelectionCharOffset = -5;

        //    richTextBoxShearStrength.SelectionStart = 27;
        //    richTextBoxShearStrength.SelectionLength = "s".Length;
        //    richTextBoxShearStrength.SelectionCharOffset = -5;

        //    richTextBoxWeight.SelectionStart = 17;
        //    richTextBoxWeight.SelectionLength = "s".Length;
        //    richTextBoxWeight.SelectionCharOffset = -5;

        //    richTextBoxRBK0.SelectionStart = 38;
        //    richTextBoxRBK0.SelectionLength = "B,k0".Length;
        //    richTextBoxRBK0.SelectionCharOffset = -5;

        //    richTextBoxGammaM.SelectionStart = "Partial safety factor for material ".Length + 1;
        //    richTextBoxGammaM.SelectionLength = "M".Length;
        //    richTextBoxGammaM.SelectionCharOffset = -5;

        //}
        #endregion

        private void comboBoxColumnGrid_SelectedValueChanged(object sender, SelectionChangedEventArgs e)
        {
            //BitmapImage image = new BitmapImage();
            //image.BeginInit();
            
            if (comboBoxColumnGrid.SelectedIndex == 0)
            {

                //imageBox.Source = new BitmapImage(new Uri(@"pack://Pictures//Quadratic.PNG"));
                //imageBox.Source = Image.FromFile("Pictures\\Quadratic.PNG");

                //lblGridSelected.Text = "Quadratic grid selected";
                MessageBox.Show("Rechtekisch");
            }
            else
            {
                 MessageBox.Show("Quadratisch");
            }

        }
    }
}
