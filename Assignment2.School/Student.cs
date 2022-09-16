namespace Assignment2.School;

using System;

public class Student {

    enum Status {
        New,
        Active,
        Dropout,
        Graduated
    }

    public int Id { get; init; }
    public string GivenName { get; set; }
    public string Surname { get; set; }
    Status StudentStatus { 
        get => Status.New;
        }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime GraduationDate { get; set; }

    public string toString() {

        return $"{ Id } { GivenName } { Surname } { StudentStatus } { StartDate.ToString("dd/MM/yyyy") } { EndDate.ToString("dd/MM/yyyy") } { GraduationDate.ToString("dd/MM/yyyy") }";

    }


}