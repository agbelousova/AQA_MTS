using Bogus;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Fakers;

public class SectionsFaker : Faker<Section>
{
    public SectionsFaker()
    {
        RuleFor(x => x.Name, f => f.Random.AlphaNumeric(15));
        RuleFor(x => x.Description, f => f.Random.AlphaNumeric(10));
        RuleFor(x => x.SuiteId, f => f.Random.Number(1, 1));
    }
}