using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class History
    {
        public int Id { get; set; }
        public string PatientFullName { get; set; } = null!;
        public string PatientContacts { get; set; } = null!;
        public string Diagnosis { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string Treatment { get; set; } = null!;

        public History()
        {

        }
        public History(History history)
        {
            Id = history.Id;
            PatientFullName = history.PatientFullName;  
            PatientContacts = history.PatientContacts;  
            Diagnosis = history.Diagnosis;
            Department = history.Department;
            Treatment = history.Treatment;
        }
    }
}
