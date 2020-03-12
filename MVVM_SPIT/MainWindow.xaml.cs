using MVVM_SPIT.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace MVVM_SPIT
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static ResultContext db = new ResultContext();
        public MainWindow()
        {
            InitializeComponent();
            db.RequestResults.Add(new RequestResult { Desctription = "Desct", Source = "Google", Url = "url.com" });
            db.SaveChanges();
        }
    }
}
