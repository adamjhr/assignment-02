namespace Assignment2.School;

public record ImmutableStudent {
    public ImmutableStudent (int id, string givenName, string surname, DateTime startDate, 
                            DateTime endDate, DateTime graduationDate) => 
                            (Id, GivenName, Surname, StartDate, EndDate, GraduationDate) = (id, givenName!, surname!, startDate, endDate, graduationDate);


    public int Id { get; init; }
    public string GivenName { get; init; }
    public string Surname { get; init; }
    
    // skal være readonly
    Status StudentStatus { 
        get {
            if (DateTime.Compare(StartDate, DateTime.Now) >= 0) return Status.New;
            if (DateTime.Compare(EndDate, DateTime.Now) > 0) return Status.Active;
            if (DateTime.Compare(EndDate, GraduationDate) < 0) return Status.Dropout;
            /*if (DateTime.Compare(GraduationDate, DateTime.Now) <= 0)*/ return Status.Graduated;
        }
        }
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
    public DateTime GraduationDate { get; init; }

}