using DataAccess.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace DataAccess
{
    public class DataViewModel : ViewModelBase
    {
        public MedicalHistoriesContext _dbContext;

        public DataViewModel()
        {
            DeletePatientCommand = new Command(DeletePatient);
            AddNewPatientCommand = new Command(AddNewPatient);
            UpdatePatientCommand = new Command(UpdatePatient);
            _newPatient = new History
            {
                PatientFullName = "",
                PatientContacts = "",
                Department = "",
                Diagnosis = "",
                Treatment = ""
            };
        }

        protected ObservableCollection<History> _histories { get; set; }
        public ObservableCollection<History> Histories
        {
            get { return _histories; }
            set
            {
                _histories = value;
                OnPropertyChanged("MedicalHistories");
            }
        }

        private History _selectedPatient;

        public History SelectedPatient
        {
            get { return _selectedPatient; }
            set
            {
                _selectedPatient = value;
                OnPropertyChanged("SelectedPatient");
            }
        }

        public ICommand DeletePatientCommand { get; set; }
        public void DeletePatient(object args)
        {
            if (_selectedPatient != null)
            {
                _dbContext.Histories.Remove(SelectedPatient);
                _dbContext.SaveChanges();
                Histories?.Remove(SelectedPatient);
            }
        }
        
        private History _newPatient;
        public History NewPatient
        {
            get { 
                return _newPatient; }
            set
            {
                _newPatient = value;
                OnPropertyChanged("NewPatient");
            }
        }

        public ICommand AddNewPatientCommand { get; set; }
        public void AddNewPatient(object args)
        {
            if (_newPatient.Treatment != "" &&
                _newPatient.PatientContacts != "" &&
                _newPatient.PatientFullName != "" &&
                _newPatient.Diagnosis != "" &&
                _newPatient.Department != "")
            {
                _newPatient.Id = Histories.Count == 0 ? 1 : Histories.Last().Id + 1;
                _dbContext.Histories.Add(_newPatient);
                _dbContext.SaveChanges();
                Histories.Add(_newPatient);

                _newPatient = new History();
                _newPatient.PatientFullName = "";
                _newPatient.PatientContacts = "";
                _newPatient.Department = "";
                _newPatient.Diagnosis = "";
                _newPatient.Treatment = "";
            }
        }
        public ICommand UpdatePatientCommand { get; set; }
        public void UpdatePatient(object args)
        {
            if (SelectedPatient!=null)
            {
                _dbContext.Histories.Update(SelectedPatient);
                _dbContext.SaveChanges();
            }
        }
    }
    
}
