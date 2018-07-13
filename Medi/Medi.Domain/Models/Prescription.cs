using System;

namespace Medi.Domain.Models
{
    public class Prescription
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DrugType DrugType { get; set; }

        public int PrescribedDosage { get; set; }

        public int AdministrationDosage { get; set; }

        public string Location { get; set; }

        public string Doctor { get; set; }

        public DateTime DatePrescribed { get; set; }

        public DateTime ExpriationDate { get; set; }

        public bool FollowUpAppointment { get; set; }

        public bool Repeat { get; set; }
    }

    public enum DrugType
    {
        Capsule = 1,
        Tablet = 2,
        Liquid = 3
    }

}
