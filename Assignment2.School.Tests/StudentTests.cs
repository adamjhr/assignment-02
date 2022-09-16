namespace Assignment2.School.Tests;

using FluentAssertions;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

        var student = new Student{  Id = 0, GivenName="Peter", Surname="Petersen", StartDate=new DateTime(2020, 05, 09, 9, 15, 00), EndDate=new DateTime(2021, 05, 09, 9, 15, 00), GraduationDate=new DateTime(2019, 05, 09, 9, 15, 00)};

        var studentString = student.toString();

        studentString.Should().BeEquivalentTo("0 Peter Petersen New 05/09/2020 05/09/2021 05/09/2019");

    }
}