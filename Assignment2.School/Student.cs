namespace Assignment2.School;

using System;

public class Student {

    public int Id { get; init; }
    public string GivenName { get; set; } = null!;
    public string Surname { get; set; } = null!;
    
    // skal være readonly
    Status StudentStatus { 
        get {
            if (DateTime.Compare(StartDate, DateTime.Now) >= 0) return Status.New;
            if (DateTime.Compare(EndDate, DateTime.Now) > 0) return Status.Active;
            if (DateTime.Compare(EndDate, GraduationDate) < 0) return Status.Dropout;
            /*if (DateTime.Compare(GraduationDate, DateTime.Now) <= 0)*/ return Status.Graduated;
        }
        }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime GraduationDate { get; set; }

    public string toString() {

        return $"{ Id } { GivenName } { Surname } { StudentStatus } { StartDate.ToString("dd/MM/yyyy") } { EndDate.ToString("dd/MM/yyyy") } { GraduationDate.ToString("dd/MM/yyyy") }";

    }


}