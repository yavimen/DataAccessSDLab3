using AutoMapper;
using DataAccess.Models;
using System;
using System.Linq;
using System.Windows;

namespace DataAccess
{
    public partial class App : Application
    {
        protected DataModel _dataModel;
        protected DataViewModel _dataViewModel;
        protected IMapper _mapper;
        protected MainWindow _mainWindow;
        public App()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DataModelProfile>();
            });
            _mapper = new Mapper(configuration);
            _dataModel = new DataModel(new MedicalHistoriesContext());
            _dataViewModel = _mapper.Map<DataModel, DataViewModel>(_dataModel);
            _mainWindow = new MainWindow() { DataContext = _dataViewModel };
            _mainWindow.Show();
        }
        protected override void OnExit(ExitEventArgs args)
        {
            try
            {
            }
            catch (Exception)
            {
                base.OnExit(args);
                throw;
            }
        }
    }
}
