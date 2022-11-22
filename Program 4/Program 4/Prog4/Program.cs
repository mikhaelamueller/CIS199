// R8507
// CIS 199-01
// Due April 18, 2021
// Program 4
// Console Application that a keeps a record of the repair that a car repair technician may carry out at an automobile repair company.
using System;
//main class
class RepairRecord
{ //method
    public RepairRecord(int ServiceLocationZipCode, int ModelYear, string ModelNumber, string SerialNumber, int AppointmentLength, string TechnicianName, bool WarrantyCoverage)
    {
        this.ServiceLocationZipCode = ServiceLocationZipCode;
        this.ModelYear = ModelYear;
        this.ModelNumber = ModelNumber;
        this.SerialNumber = SerialNumber;
        this.AppointmentLength = AppointmentLength;
        this.TechnicianName = TechnicianName;
        this.WarrantyCoverage = WarrantyCoverage;
    }

    public RepairRecord(int v1, string v2, string v3, int v4, string v5, bool v6)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
        this.v4 = v4;
        this.v5 = v5;
        this.v6 = v6;
    }

    string ModelNumber, SerialNumber, TechnicianName;
    int ServiceLocationZipCode, AppointmentLength;
    bool WarrantyCoverage;
    double Cost;
    private int v1;
    private string v2;
    private string v3;
    private int v4;
    private string v5;
    private bool v6;

    public int ModelYear { get; private set; }

    // zip code
    void setServiceLocationZipCode(int ServiceLocationZipCode)
    {
        if (ServiceLocationZipCode <= 99999 && ServiceLocationZipCode >= 00000)
            this.ServiceLocationZipCode = ServiceLocationZipCode;
        else
            this.ServiceLocationZipCode = 40204;
    }

    int getServiceLocationZipCode()
    {
        return ServiceLocationZipCode;
    }
    //model number
    void setStrings(string ModelNumber, string SerialNumber, string TechnicianName)
    {
        if (ModelNumber.Length == 5)
            this.ModelNumber = ModelNumber;
        if (SerialNumber.Length == 10)
            this.SerialNumber = SerialNumber;
        if (!(String.IsNullOrWhiteSpace(TechnicianName)))
            this.TechnicianName = TechnicianName;
    }

    string getStrings()
    {
        return "\nModel Number: " + ModelNumber + "\tSerial Number: " + SerialNumber + "\tTechnician Name: " + TechnicianName;
    }
    void setModelYear(int ModelYear)
    {
        if (ModelYear >= 2000 && ModelYear <= 2021)
            this.ModelYear = ModelYear;
    }

    int getModelYear()
    {
        return ModelYear;
    }
    //length of appointment
    void setAppointmentLength(int AppointmentLength)
    {
        if (AppointmentLength >= 15 && AppointmentLength <= 180)
            this.AppointmentLength = AppointmentLength;
    }

    int getAppointmentLength()
    {
        return AppointmentLength;
    }
    //warranty coverage -- either true or false
    void setWarrantyCoverage(bool WarrantyCoverage)
    {
        this.WarrantyCoverage = WarrantyCoverage;
    }

    bool getWarrantyCoverage()
    {
        return WarrantyCoverage;
    }
    //the cost
    double CalcCost()
    {
        if (WarrantyCoverage == false)
            Cost = 25 + 1.50 * AppointmentLength;
        else
            Cost = 20;
        return Cost;
    }
    // string of zip, make and model,serial number, tech, appt length and warranty
    public new string ToString()
    {
        return "Service Location Zip Code: " + ServiceLocationZipCode + "\nYear:" + ModelYear + "\nMake and Model: " + ModelNumber + "\nSerial Number: " + SerialNumber + "\nTechnician Name: " + TechnicianName + "\nAppointment Length: " + AppointmentLength + "\nWarranty Coverage?: " + WarrantyCoverage;
    }

    public static void DisplayRepairRecord(RepairRecord[] obj)
    {
        for (int i = 0; i < obj.Length; i++)
        {
            Console.WriteLine("\n ");
            Console.WriteLine(obj[i].ToString());
            Console.WriteLine("Calculate Cost Output: " + obj[i].CalcCost());
        }
    }
    //what each will output
    static void Main()
    {
        RepairRecord[] obj = new RepairRecord[7];
        obj[0] = new RepairRecord(53232, 2011,"Toyota Matrix", "D50102034", 40, "Monica", true);
        obj[1] = new RepairRecord(53332, 2000, "Honda Accord", "CP30104032", 50, "Jeffrey", false);
        obj[2] = new RepairRecord(53242,  2019, "Tesla Model 3", "F530102033", 120, "Spencer", true);
        obj[3] = new RepairRecord(53262, 2020, "Ford F150", "AP30102031", 140, "Bob", false);
        obj[4] = new RepairRecord(53272, 2001, "Kia Soul", "AR30102035", 130, "Jackson", true);
        obj[5] = new RepairRecord(53282, 2018, "Honda Odyssey", "DP30102044", 40, "Katie", false);
        RepairRecord.DisplayRepairRecord(obj);

        obj[0].setStrings("Toyota Matrix", "D50102034", "Monica");
        obj[1].setAppointmentLength(200);
        obj[2].setServiceLocationZipCode(123456);
        obj[3].setWarrantyCoverage(true);
        obj[4].setStrings("Honda Odyssey", "DP30102044", null);
        obj[5].setAppointmentLength(130);
        Console.WriteLine("\nUpdated details are: ");
        RepairRecord.DisplayRepairRecord(obj);

    }
}