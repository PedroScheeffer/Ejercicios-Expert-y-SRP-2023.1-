using System;
using System.Collections.Generic;
namespace Library
{
    public class Agenda
    {
        /* Mover a appointmment
        public string id {get; private set;}
        public DateTime appointmentTime {get; private set;}
        public string ubication {get;private set;}
        */
        List<Appointment> appointments = new List<Appointment>();

        public Agenda()
        {

        }
        public void addAppointment(Appointment consult)
        {
            appointments.Add(consult);
        }
        public void removeAppointment(Appointment consult)
        {
            foreach (var appointment in appointments)
            {
                if (appointment.id == consult.id)
                {
                    appointments.Remove(appointment);
                }
            }
        }
        public string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            Patient patient = new Patient(name, id, phoneNumber);
            if (!patient.isValid())
            {
                return "El paciente no es valido";
            }
            Ubication ubication = new Ubication(appoinmentPlace);
            if (!ubication.isValid())
            {
                return "La ubicación no es valida";
            }
            Doctor doc = new Doctor(doctorName);
            if (!doc.isValid())
            {
                return "El doctor no es valido";
            }
            Appointment appointment = new Appointment(id, patient, doc, date, ubication);
            this.addAppointment(appointment);
            return "Agendado con exito";
        }
    }
}