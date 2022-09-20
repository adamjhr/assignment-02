namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void Reverse_String_Delegate_Monkey_Gives_yeknoM()
    {
        // Given
        using var writer = new StringWriter();
        Console.SetOut(writer);
        string monkey = "Monkey";
    
        // When
        Delegates.PrintReverse(monkey);
        var output = writer.GetStringBuilder().ToString().TrimEnd();

        // Then
        output.Should().Be("yeknoM");
    }

    [Fact]
    public void Reverse_String_Delegate_Andreas_Guldborg_Er_Sej_Gives_jeS_rE_grobdluG_saerdnA()
    {
        // Given
        using var writer = new StringWriter();
        Console.SetOut(writer);
        string input = "Andreas Guldborg Er Sej";
    
        // When
        Delegates.PrintReverse(input);
        var output = writer.GetStringBuilder().ToString().TrimEnd();
    
        // Then
        output.Should().Be("jeS rE grobdluG saerdnA");
    }

    [Fact]
    public void Reverse_String_Delegate_123_456_78_Gives_87_654_321()
    {
        // Given
        using var writer = new StringWriter();
        Console.SetOut(writer);
        string input = "123 456 78";
    
        // When
        Delegates.PrintReverse(input);
        var output = writer.GetStringBuilder().ToString().TrimEnd();
    
        // Then
        output.Should().Be("87 654 321");
    }

    [Fact]
    public void Product_Of_2_And_3_Gives_6()
    {
        // Given
        var a = 2.0; var b = 3.0;
    
        // When
        var product = Delegates.ProductOfTwoNumbers(a, b);
    
        // Then
        product.Should().Be(6.0);
    }

    [Fact]
    public void Product_Of_5_5_And_6_5_Gives_35_75()
    {
        // Given
        var a = 5.5; var b = 6.5;
    
        // When
        var product = Delegates.ProductOfTwoNumbers(a, b);
    
        // Then
        product.Should().Be(35.75);
    }

    [Fact]
    public void Product_Of_Minus_3_And_3_5_Gives_Minus_10_5()
    {
        // Given
        var a = -3; var b = 3.5;
    
        // When
        var product = Delegates.ProductOfTwoNumbers(a, b);
    
        // Then
        product.Should().Be(-10.5);
    }

    [Fact]
    public void NumericallyEquivalent_42_Equals_42()
    {
        // Given
        var a = 42; var b = "42";
    
        // When
        var result = Delegates.NumericallyEqualStringAndInteger(a, b);
    
        // Then
        result.Should().Be(true);
    }

    [Fact]
    public void NumericallyEquivalent_0042_Equals_42()
    {
        // Given
        var a = 42; var b = "0042";
    
        // When
        var result = Delegates.NumericallyEqualStringAndInteger(a, b);
    
        // Then
        result.Should().Be(true);
    }

    [Fact]
    public void NumericallyEquivalent_4200_Does_Not_Equal_42()
    {
        // Given
        var a = 42; var b = "4200";
    
        // When
        var result = Delegates.NumericallyEqualStringAndInteger(a, b);
    
        // Then
        result.Should().Be(false);
    }

    [Fact]
    public void NumericallyEquivalent_abc_Does_Not_Equal_42()
    {
        // Given
        var a = 42; var b = "abc";
    
        // When
        var result = Delegates.NumericallyEqualStringAndInteger(a, b);
    
        // Then
        result.Should().Be(false);
    }

    [Fact]
    public void NumericallyEquivalent_With_Space_Still_Works()
    {
        // Given
        var a = 12; var b = " 012";
    
        // When
        var result = Delegates.NumericallyEqualStringAndInteger(a, b);
    
        // Then
        result.Should().Be(true);
    }
}
