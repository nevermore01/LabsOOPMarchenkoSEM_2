using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup.Localizer;

namespace Task2.Presenters
{
    class CalculatorPresenter
    {
        private MainWindow _main;
        private CalculatorModel _model;
        
        public CalculatorPresenter(MainWindow main)
        {
            this._main = main;
            _model = new CalculatorModel();

            //Проверяю на наличие символа ',' и заменяю его на '.', чтобы не было ошибки
            _main.InputTextBox.TextChanged += InputTextBox_TextChanged;
            
            //Присваиваю каждому объекту типа Button в MainGrid событие нажатия кнопки
            foreach (var i in _main.MainGrid.Children)
            {
                if (i is Button)
                {
                    ((Button) i).Click += Button_Click;
                }
            }
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            char[] arr = ((TextBox) sender).Text.ToCharArray();
            bool IsContains = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ',')
                {
                    IsContains = true;
                    arr[i] = '.';
                }
            }
            if(IsContains)
                _main.InputTextBox.Text = new string(arr);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string content = (string)((Button) sender).Content;
            switch (content)
            {
                case "=":
                    _main.InputTextBox.Text = new DataTable().Compute(_main.InputTextBox.Text,null).ToString();
                    break;
                case "C":
                    _main.InputTextBox.Text = "";
                    break;
                default:
                    _main.InputTextBox.Text += content;
                    break;
            }
        }
    }
}
