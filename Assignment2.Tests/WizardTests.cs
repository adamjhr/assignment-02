namespace Assignment2.Tests;

public class WizardTests
{
    [Fact]
    public void WizardCollection_contains_12_wizards()
    {
        var wizards = WizardCollection.Create();

        Assert.Equal(12, wizards.Count());
    }

    [Theory]
    [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
    [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
    public void Spot_check_wizards(string name, string medium, int year, string creator)
    {
        var wizards = WizardCollection.Create();

        Assert.Contains(wizards, w => w == new Wizard(name, medium, year, creator));
    }

    [Fact]
    public void Rowling_Created_Dumbledore_And_Voldemort()
    {
        // Given
        var creator = "Rowling";
    
        // When
        var LINQ_wizards = Queries.Get_Wizard_Names_From_Creator_LINQ(creator);
        var Extension_wizards = QueriesExtensions.Get_Wizard_Names_From_Creator_Extension(creator);
    
        // Then
        var Expected_Result = new[]{"Albus Dumbledore", "Tom Riddle"};
        LINQ_wizards.Should().BeEquivalentTo(Expected_Result);
        Extension_wizards.Should().BeEquivalentTo(Expected_Result);
    }

    [Fact]
    public void First_Sith_Lord_Is_From_1977()
    {
        // Given
        var prefix = "Darth";
    
        // When
        var LINQ_year = Queries.First_Year_Where_Wizard_Appear_With_Given_Prefix(prefix);
        var Extension_Year = QueriesExtensions.First_Year_Where_Wizard_Appear_With_Given_Prefix(prefix);
    
        // Then
        var Expected_Year = 1977;
        LINQ_year.Should().Be(Expected_Year);
        Extension_Year.Should().Be(Expected_Year);
    }

    [Fact]
    public void Wizards_From_Harry_Potter_Include_Dumbledore_And_Riddle()
    {
        // Given
        var bookseries = "Harry Potter";
    
        // When
        var LINQ_wizards = Queries.Wizard_Name_And_Year_From_Bookseries(bookseries);
        var Extension_wizards = QueriesExtensions.Wizard_Name_And_Year_From_Bookseries(bookseries);
    
        // Then
        var Expected_List = new[]{("Albus Dumbledore",1997), ("Tom Riddle",1998)};
        LINQ_wizards.Should().BeEquivalentTo(Expected_List);
        Extension_wizards.Should().BeEquivalentTo(Expected_List);
    }

    [Fact]
    public void List_Of_Wizard_Names_Grouped_By_Creator_Sorted_Descending_By_Creator_Name_And_Wizard_Name()
    {
        // Given

        // When
        var LINQ_wizards = Queries.Wizard_Names_Grouped_By_Creator_Sorted_Descending_By_Creator_Then_Wizard();
        var Extension_wizards = QueriesExtensions.Wizard_Names_Grouped_By_Creator_Sorted_Descending_By_Creator_Then_Wizard();
    
        // Then
        var Expected_List = new[]{
            "Sorcerer Mickey Mouse",
            "Professor Marvel",
            "Tim the Enchanter",
            "Merlin",
            "Sauron",
            "Gandalf the White",
            "Gandalf the Grey",
            "Tom Riddle",
            "Albus Dumbledore",
            "Darth Vader",
            "Darth Sidious",
            "The White Witch"
        };

        LINQ_wizards.Should().ContainInOrder(Expected_List);
        Extension_wizards.Should().ContainInOrder(Expected_List);
    }
}

