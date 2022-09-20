namespace Assignment2;

public class Queries
{
    public static IEnumerable<string> Get_Wizard_Names_From_Creator_LINQ(string creator) {
        var wizards = WizardCollection.Create();

        var result = from wizard in wizards
                where wizard.Creator.Contains(creator)
                select new {Name = wizard.Name};

        foreach (var wizard in result) {
            yield return wizard.Name;
        }
    }

    public static int? First_Year_Where_Wizard_Appear_With_Given_Prefix(string prefix) {
        var wizards = WizardCollection.Create();

        var result = from wizard in wizards
                where wizard.Name.StartsWith(prefix)
                orderby wizard.Year ascending
                select new {Year = wizard.Year};
        
        return result.Take(1).Single().Year;        
    }

    public static IEnumerable<(string name, int? year)> Wizard_Name_And_Year_From_Bookseries(string bookseries) {
        var wizards = WizardCollection.Create();

        var result = from wizard in wizards
                where wizard.Medium.Contains(bookseries)
                select (wizard.Name, wizard.Year);

        return result;
    }

    public static IEnumerable<string> Wizard_Names_Grouped_By_Creator_Sorted_Descending_By_Creator_Then_Wizard() {
        var wizards = WizardCollection.Create();

        var result = from wizard in wizards
                    orderby wizard.Name descending
                    orderby wizard.Creator descending
                    select wizard.Name;

        return result;
    }
}

public static class QueriesExtensions 
{
    public static IEnumerable<string> Get_Wizard_Names_From_Creator_Extension(string creator) {
        var wizards = WizardCollection.Create();

        var result = wizards.Where(w => w.Creator.Contains(creator))
               .Select(w => new {w.Name});

        
        foreach (var wizard in result) {
            yield return wizard.Name;
        }
    }

    public static int? First_Year_Where_Wizard_Appear_With_Given_Prefix(string prefix) {
        var wizards = WizardCollection.Create();

        var result = wizards.Where(w => w.Name.StartsWith(prefix))
               .OrderBy(w => w.Year)
               .Take(1)
               .Select(w => new {w.Year});

        return result.Single().Year;
    }

    public static IEnumerable<(string name, int? year)> Wizard_Name_And_Year_From_Bookseries(string bookseries) {
        var wizards = WizardCollection.Create();

        var result = wizards.Where(w => w.Medium.Contains(bookseries))
                    .Select(w => (w.Name, w.Year));

        return result;
    }

    public static IEnumerable<string> Wizard_Names_Grouped_By_Creator_Sorted_Descending_By_Creator_Then_Wizard() {
        var wizards = WizardCollection.Create();

        var result = wizards.OrderByDescending(w => w.Name)
                    .OrderByDescending(w => w.Creator)
                    .Select(w => w.Name);

        return result;
    }
}