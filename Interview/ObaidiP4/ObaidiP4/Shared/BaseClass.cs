
namespace ObaidiP4.Shared
{
    public class BaseClass
    {  
        public DepreciationStraightLine DepreciationStraightLine { get; set; } = new DepreciationStraightLine();
        public DepreciationDoubleDeclining DepreciationDoubleDeclining { get; set; } = new DepreciationDoubleDeclining();
        public string[] DepreciationType { get; set; } = new[] { "Straight Line", "Double Declining" };
    }
}
