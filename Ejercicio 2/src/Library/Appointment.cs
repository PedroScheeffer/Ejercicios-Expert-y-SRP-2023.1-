using System;
namespace Library
{
    public class Appointment
    {
        public string id { get; private set; }
        public Patient patient { get; private set; }
        public Doctor doctor { get; private set; }
        public DateTime dateOfAppointment { get; private set; }
        public Ubication ubication { get; private set; }
        public Doctor doc { get; private set; }
        public DateTime date { get; private set; }

        public Appointment(string id, Patient patient, Doctor doctor, DateTime date, Ubication ubication)
        {
            this.id = id;
            this.patient = patient;
            this.doctor = doctor;
            this.dateOfAppointment = date;
            this.ubication = ubication;
        }
    }
}