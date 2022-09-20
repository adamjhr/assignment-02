namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Flatten_List_Of_Numbers()
    {
        // HUSK: Spar keystrokes
        var xs = new IEnumerable<int>[] { new List<int>{1, 2, 4}, new List<int>{5, 99}, new List<int>{130, 23} };

        var result = xs.Aggregate((l1, l2) => l1.Concat(l2));

        result.Should().BeEquivalentTo(new []{1, 2, 4, 5, 99, 130, 23});
    }

    [Fact]
    public void Select_divisible_by_7_less_than_42()
    {
        // HUSK: Spar keystrokes
        var ys = new int[] { 1, 7, 4, 5, 8, 9, 17, 42, 14, 21, 56, 70 };

        var result = ys.Where((num) => num < 42 && num % 7 == 0);

        result.Should().BeEquivalentTo(new []{ 7, 14, 21 });
    }

    [Fact]
        public void Select_leap_years()
    {
        // HUSK: Spar keystrokes
        var ys = new int[] { 1200, 4, 1600, 1700, 1704, 99, 32, 41 };

        var result = ys.Where((year) => (year % 4 == 0 && year % 100 != 0) || year % 400 == 0 );

        result.Should().BeEquivalentTo(new []{ 1200, 4, 1600, 1704, 32 });
    }

    [Fact]
    public void Url_scheme_is_https() {

        var url = new Uri("https://docs.microsoft.com/en-us/dotnet/api/system.uri.scheme?view=net-6.0");

        var result = url.isSecure();

        result.Should().BeTrue();

    }

    [Fact]
        public void Url_scheme_is_not_https() {

        var url = new Uri("http://docs.microsoft.com/en-us/dotnet/api/system.uri.scheme?view=net-6.0");

        var result = url.isSecure();

        result.Should().BeFalse();

    }

     [Fact]
        public void Number_of_words_is_5() {

        var words = "word   p  2388,.,.,, testing t word 1";

        var result = words.wordCount();

        result.Should().Be(5);

    }
}
