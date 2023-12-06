namespace Hospital;
//Пациент
public class Patient
{
    private Surgeon surgeon = new Surgeon();
    private Dantist dantist = new Dantist();
    private Therapist therapist = new Therapist();
    public int treatmentPlan;
    public string namePatient;
    
    public Patient(string namePatient, int treatmentPlan)
    {
        this.namePatient = namePatient;
        this.treatmentPlan = treatmentPlan;
    }
    
    //метод, который будет назначать врача пациенту согласно плану лечения
    public void DoctorTtreatmentPlan()
    {
        switch (treatmentPlan)
        {
            case 1:
                Console.WriteLine("Вам назначен хирург.");
                surgeon.Heal();
                break;
            case 2:
                Console.WriteLine("Вам назначен дантист.");
                dantist.Heal();
                break;
            default:
                Console.WriteLine("Вам назначен терапевт.");
                therapist.Heal();
                break;
        }
    }
}