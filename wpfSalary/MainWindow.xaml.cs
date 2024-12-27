using System;
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
using static wpfSalary.MainWindow;

namespace wpfSalary
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class Data
        {
            public string workers { get; set; }
            public double m1 { get; set; }
            public double m2 { get; set; }
            public double m3 { get; set; }
            public double m4 { get; set; }
            public double m5 { get; set; }
            public double m6 { get; set; }
            public double m7 { get; set; }
            public double m8 { get; set; }
            public double m9 { get; set; }
            public double m10 { get; set; }
            public double m11 { get; set; }
            public double m12 { get; set; }
            public double total { get; set; }
            public double mid { get; set; }
        }

        private void bt_generate_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int workerCount = Convert.ToInt32(tb_count.Text);
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;
            double sum5 = 0;
            double sum6 = 0;
            double sum7 = 0;
            double sum8 = 0;
            double sum9 = 0;
            double sum10 = 0;
            double sum11 = 0;
            double sum12 = 0;
            double sumTotal = 0;
            double midTotal = 0;
            var data = new List<Data>();
            for (int i = 0; i <= workerCount; i++)
            {
                int m1 = random.Next(1000, 5000);
                int m2 = random.Next(1000, 5000);
                int m3 = random.Next(1000, 5000);
                int m4 = random.Next(1000, 5000);
                int m5 = random.Next(1000, 5000);
                int m6 = random.Next(1000, 5000);
                int m7 = random.Next(1000, 5000);
                int m8 = random.Next(1000, 5000);
                int m9 = random.Next(1000, 5000);
                int m10 = random.Next(1000, 5000);
                int m11 = random.Next(1000, 5000);
                int m12 = random.Next(1000, 5000);
                int total = m1 + m2 + m3 + m4 + m5 + m6 + m7 + m8 + m9 + m10 + m11 + m12;
                double mid = total / 12;
                sum1 += m1;
                sum2 += m2;
                sum3 += m3;
                sum4 += m4;
                sum5 += m5;
                sum6 += m6;
                sum7 += m7;
                sum8 += m8;
                sum9 += m9;
                sum10 += m10;
                sum11 += m11;
                sum12 += m12;
                sumTotal += total;
                midTotal += mid;

                data.Add(new Data
                {
                    workers = $"Сотрудник {i}",
                    m1 = m1,
                    m2 = m2,
                    m3 = m3,
                    m4 = m4,
                    m5 = m5,
                    m6 = m6,
                    m7 = m7,
                    m8 = m8,
                    m9 = m9,
                    m10 = m10,
                    m11 = m11,
                    m12 = m12,
                    total = total,
                    mid = mid
                });
            }

            data.Add(new Data
            {
                workers = "ИТОГО",
                m1 = sum1,
                m2 = sum2,
                m3 = sum3,
                m4 = sum4,
                m5 = sum5,
                m6 = sum6,
                m7 = sum7,
                m8 = sum8,
                m9 = sum9,
                m10 = sum10,
                m11 = sum11,
                m12 = sum12,
                total = sumTotal,
                mid = midTotal / workerCount
            });

           dg_result.ItemsSource = data;
        }
    }
}
