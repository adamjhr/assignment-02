namespace Assignment2.School.Tests;

using FluentAssertions;

public class UnitTest1
{
    [Fact]
    public void Student_ToString_returns_0_Peter_Petersen_Graduated_05092020_05092021_05092021()
    {

        var student = new Student{  Id = 0, GivenName="Peter", Surname="Petersen", StartDate=new DateTime(2020, 09, 05, 9, 15, 00), EndDate=new DateTime(2021, 09, 05, 9, 15, 00), GraduationDate=new DateTime(2021, 09, 05, 9, 15, 00)};

        var studentString = student.toString();

        studentString.Should().BeEquivalentTo("0 Peter Petersen Graduated 05-09-2020 05-09-2021 05-09-2021");

    }

    [Fact]
    public void ImmutableStudent_ToString_returns_0_Peter_Petersen_Graduated_05092020_05092021_05092021()
    {

        var student = new ImmutableStudent(0, "Peter", "Petersen", new DateTime(2020, 09, 05, 9, 15, 00), new DateTime(2021, 09, 05, 9, 15, 00), new DateTime(2021, 09, 05, 9, 15, 00));

        var studentString = student.ToString();

        studentString.Should().BeEquivalentTo("ImmutableStudent { Id = 0, GivenName = Peter, Surname = Petersen, StartDate = 05-09-2020 09:15:00, EndDate = 05-09-2021 09:15:00, GraduationDate = 05-09-2021 09:15:00 }");

    }
}