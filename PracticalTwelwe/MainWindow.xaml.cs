using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticalTwelwe
{
    public partial class MainWindow : Window
    {
        public DateTime CurrentDateTime => DateTime.Now;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this; //Установка контекста данных
        }
        //Кнопка расчета
        private void CalculateCircumference_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(DiameterTextBox.Text, out double diameter)) //преобразование введеного текста в число (диаметр)
            {
                //вычисление длины окрудности 
                double lenght = Math.PI * diameter;
                CircumferenceResultTextBlock.Text = $"Длина окружности {lenght}";
            }
            else
            {
                MessageBox.Show("Введите корректный диаметр окружности.");
                CircumferenceResultTextBlock.Text = string.Empty; //Очищение результата
            }
        }
        private void CalculateNumber_Click(object sender, RoutedEventArgs e) 
        {
            if (int.TryParse(ThreeDigitNumberTextBox.Text, out int number) && number >= 100 && number <= 999) 
            {
                //извлечение последней цифры из числа
                int lastDight = number % 10;
                int newNumber = lastDight * 100 + (number / 10);
                NumberResultTextBlock.Text = $"Новое число: {newNumber}";
            }
            else
            {
                MessageBox.Show("Введите корректное трехзначное число.");
                NumberResultTextBlock.Text = string.Empty; //очищаем результат
            }
        }
        private void Exit_Click(object sender, RoutedEventArgs e) 
        {
            this.Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программа для расчета длины окружности и перестановки цифр.", "О программе", MessageBoxButton.OK);
        }
    }
}