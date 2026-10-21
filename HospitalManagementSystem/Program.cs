using HospitalManagementSystem.Services;
using HospitalManagementSystem.Models;
List<Patient> patient = new List<Patient>();
PatientServices patientServices = new PatientServices(patient);
Patient ps1 = new Patient("1", "Blessy", 12, "123456789");
Patient ps2 = new Patient("2", "Catherine", 20, "123456789");
patientServices.RegisterPatient(ps1);
patientServices.RegisterPatient(ps2);
Console.WriteLine("-----------------------");
Console.WriteLine("Displayig all patients..");
foreach (Patient p in patientServices.DisplayPatients())
{
    Console.WriteLine($"Patient Id: " + p.PatientId + " |" + $"Patient Name: " + p.FullName + " |" + $"Patient Age: " + p.Age + " |" + $"Patient phone number: " + p.PhoneNumber);

}
Console.WriteLine("-----------------------");
Console.WriteLine("Search Patient: eg(Arun)");
foreach (Patient p in patientServices.SearchByName("Blessy"))
{
    Console.WriteLine("Found!!");
    Console.WriteLine(p.FullName);
}
Console.WriteLine("-----------------------");
Console.WriteLine("Updating Patient: ");
bool updatePatient = patientServices.UpdatePatient("2", "Alice", 1, "123456789");
if (updatePatient)
{
    Console.WriteLine("Updated Successfully..");
}
Console.WriteLine("-----------------------");
Console.WriteLine("Displayig all patients..");
foreach (Patient p in patientServices.DisplayPatients())
{
    Console.WriteLine($"Patient Id: " + p.PatientId + " |" + $"Patient Name: " + p.FullName + " |" + $"Patient Age: " + p.Age + " |" + $"Patient phone number: " + p.PhoneNumber);

}
Console.WriteLine("-----------------------");
Console.WriteLine("Deleting Patient: ");
bool deletePatient = patientServices.DeletePatient("2");
if (deletePatient)
{
    Console.WriteLine("Deleted Successfully..");
}
Console.WriteLine("-----------------------");
Console.WriteLine("Displayig all patients..");
foreach (Patient p in patientServices.DisplayPatients())
{
    Console.WriteLine($"Patient Id: " + p.PatientId + " |" + $"Patient Name: " + p.FullName + " |" + $"Patient Age: " + p.Age + " |" + $"Patient phone number: " + p.PhoneNumber);

}
List<Doctor> doctor = new List<Doctor>();
DoctorServices doctorServices = new DoctorServices(doctor);
Doctor ds1 = new Doctor("100", "Blessy","Cardiology",800m);
Doctor ds2 = new Doctor("101", "Catherine", "Neurology", 1800m);
doctorServices.AddDoctor(ds1);
doctorServices.AddDoctor(ds2);
Console.WriteLine("-----------------------");
Console.WriteLine("Displayig all Doctors..");
foreach (Doctor p in doctorServices.DisplayDoctors())
{
    Console.WriteLine($"Doctor Id: " + p.DoctorId + " |" + $"Doctor's Name: " + p.FullName + " |" + $"Doctor Specialization: " + p.Specialization + " |" + $"Consultation Fee : " + p.ConsultationFee);

}
Console.WriteLine("-----------------------");
Console.WriteLine("Search Doctor: eg(100)");
foreach (Doctor p in doctorServices.SearchByName("Blessy"))
{
    Console.WriteLine("Found!!");
    Console.WriteLine(p.FullName);
}
Console.WriteLine("-----------------------");
Console.WriteLine("Updating Doctor: ");
bool updateDoctor = doctorServices.UpdateDoctor("101", "Catherine", "Endocronology", 9190m);
Console.WriteLine(updateDoctor);
if (updateDoctor)
{
    Console.WriteLine("Updated Successfully..");
}
Console.WriteLine("-----------------------");
Console.WriteLine("Displayig all doctors..");
foreach (Doctor p in doctorServices.DisplayDoctors())
{
    Console.WriteLine($"Doctor Id: " + p.DoctorId + " |" + $"Doctor's Name: " + p.FullName + " |" + $"Doctor Specialization: " + p.Specialization + " |" + $"Consultation Fee : " + p.ConsultationFee);

}
Console.WriteLine("-----------------------");
Console.WriteLine("Deleting Patient: ");
bool deleteDoctor = doctorServices.DeleteDoctor("Blessy");
if (deleteDoctor)
{
    {
        Console.WriteLine("Deleted Successfully..");
    }
    Console.WriteLine("-----------------------");
    Console.WriteLine("Displayig all patients..");
    foreach (Doctor p in doctorServices.DisplayDoctors())
    {
        Console.WriteLine($"Doctor Id: " + p.DoctorId + " |" + $"Doctor's Name: " + p.FullName + " |" + $"Doctor Specialization: " + p.Specialization + " |" + $"Consultation Fee : " + p.ConsultationFee);

    }
}
List<Appointment> appointments = new List<Appointment>();
AppointmentServices appointmentServices = new AppointmentServices(patient, doctor, appointments);
Appointment app1 = new Appointment("1000", "1", "100", DateTime.Now, "Fever", "Scheduled");
Appointment app2 = new Appointment("1001", "2", "101", DateTime.Now, "Cold", "Scheduled");

appointmentServices.BookAppointment(app1);
appointmentServices.BookAppointment(app2);
Console.WriteLine("=======================");
foreach(Appointment p in appointmentServices.DisplayAllAppointments())
{
    Console.WriteLine($"Appointment Id: " + p.AppointmentId + " |" + $"Reason: " + p.Reason + " |" + $"Date time: " + DateTime.Now + " |" + $"Status : " + p.Status);

}
Console.WriteLine("=======================");




