﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using task.Commands;
using task.Model;

namespace task.ViewModel
{
    // ViewModel цвета.
    public class ColorViewModel : ViewModelBase
    {
        // Модель цвета.
        private ColorModel _colorModel;

        // Конструктор.
        public ColorViewModel(ColorModel colorModel)
        {
            _colorModel = colorModel;
        }

        // Свойства, которые оборачивают свойства модели цвета.
        public byte Alpha
        {
            // Возвращаем значение свойства модели цвета.
            get => _colorModel.Alpha;
            // Устанавливаем значение свойства модели цвета.
            set
            {
                // При изменении свойства вызывается событие PropertyChanged.
                _colorModel.Alpha = value;
                // Вызываем событие PropertyChanged.
                OnPropertyChanged(nameof(Alpha));
            }
        }

        public byte Red
        {
            get => _colorModel.Red;
            set
            {
                _colorModel.Red = value;
                OnPropertyChanged(nameof(Red));
            }
        }

        public byte Green
        {
            get => _colorModel.Green;
            set
            {
                _colorModel.Green = value;
                OnPropertyChanged(nameof(Green));
            }
        }

        public byte Blue
        {
            get => _colorModel.Blue;
            set
            {
                _colorModel.Blue = value;
                OnPropertyChanged(nameof(Blue));
            }
        }

        // Итоговый цвет.
        public string ColorCode => _colorModel.ColorCode;

        // Метод, который возвращает строку с цветом.
        public override string ToString()
        {
            return _colorModel.ToString();
        }

        // Команды. 
        
        private DelegateCommand _changeColorCommand;

        //public ICommand ChangeColorCommand
        //{
        //    get
        //    {
        //        if (_changeColorCommand == null)
        //        {
        //            _changeColorCommand = new DelegateCommand();
        //        }
        //        return _changeColorCommand;
        //    }
        //}
        
        



    }
}