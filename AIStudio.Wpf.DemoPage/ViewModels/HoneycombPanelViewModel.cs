﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util.Controls.Commands;
using System.Windows.Input;
using AIStudio.Wpf.DemoPage.Service;
using AIStudio.Wpf.DemoPage.Models;
using System.Windows;

namespace AIStudio.Wpf.DemoPage.ViewModels
{
    public class HoneycombPanelViewModel : Dataforge.PrismAvalonExtensions.ViewModels.DockWindowViewModel
    {
        private ObservableCollection<string> data;
        public ObservableCollection<string> Data
        {
            get { return data; }
            set
            {
                if (data != value)
                {
                    data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }

		private ICommand okCommand;
        public ICommand OKCommand
        {
            get
            {
                return this.okCommand ?? (this.okCommand = new DelegateCommand(() => this.OK()));
            }
        }

        public HoneycombPanelViewModel()
        {
            DataList = DataService.GetCardDataList();
        }

		private void OK()
		{

		}

        /// <summary>
        ///     数据列表
        /// </summary>
        private IList<CardModel> _dataList;

        /// <summary>
        ///     数据列表
        /// </summary>
        public IList<CardModel> DataList
        {
            get { return _dataList; }
            set
            {
                if (_dataList != value)
                {
                    _dataList = value;
                    RaisePropertyChanged("DataList");
                }
            }
        }

        public RelayCommand AddItemCmd => new Lazy<RelayCommand>(() =>
            new RelayCommand(() => DataList.Insert(0, DataService.GetCardData()))).Value;

        public RelayCommand RemoveItemCmd => new Lazy<RelayCommand>(() =>
            new RelayCommand(() =>
            {
                if (DataList.Count > 0)
                {
                    DataList.RemoveAt(0);
                }
            })).Value;

    }

}
