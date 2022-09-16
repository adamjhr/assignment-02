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

    public void Select_divisible_by_7_less_than_42()
    {
        // HUSK: Spar keystrokes
        var ys = new int[] { 1, 7, 4, 5, 8, 9, 17, 42, 14, 21, 56, 70 };

        var result = ys.Select((num) => num < 42 && num % 7 == 0);

        result.Should().BeEquivalentTo(new []{ 7, 14, 21 });
    }

        public void Select_leap_years()
    {
        // HUSK: Spar keystrokes
        var ys = new int[] { 1200, 4, 1600, 1700, 1704, 99, 32, 41 };

        var result = ys.Select((year) => (year % 400 == 0 || year % 100 != 0) || year % 4 == 0 );

        result.Should().BeEquivalentTo(new []{ 1200, 4, 1600, 1704, 32 });
    }
}
