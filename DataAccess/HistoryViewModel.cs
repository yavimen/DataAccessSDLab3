using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HistoryViewModel:ViewModelBase
    {
        public HistoryViewModel() { }
        public HistoryViewModel(HistoryViewModel medicalHistory)
        {
            _department = medicalHistory.Department;
            _diagnosis = medicalHistory.Diagnosis;
            _patientContacts = medicalHistory.PatientContacts;
            _patientFullName = medicalHistory.PatientFullName;
            _treatment = medicalHistory.Treatment;
        }

        private string? _patientFullName;

        public string? PatientFullName
        {
            get { return _patientFullName; }
            set
            {
                _patientFullName = value;
                OnPropertyChanged("PatientFullName");
            }
        }

        private string? _patientContacts;

        public string? PatientContacts
        {
            get { return _patientContacts; }
            set
            {
                _patientContacts = value;
                OnPropertyChanged("PatientContacts");
            }
        }

        private string? _diagnosis;

        public string? Diagnosis
        {
            get { return _diagnosis; }
            set
            {
                _diagnosis = value;
                OnPropertyChanged("Diagnosis");
            }
        }

        private string? _department;

        public string? Department
        {
            get { return _department; }
            set
            {
                _department = value;
                OnPropertyChanged("Department");
            }
        }

        private string? _treatment;

        public string? Treatment
        {
            get { return _treatment; }
            set
            {
                _treatment = value;
                OnPropertyChanged("Treatment");
            }
        }
    }
}
