namespace BuilderHM.Models;
public class Milestone
{
    public string Name { get; }
    public string References { get; }
    public int? Parent { get; }
    public string Description { get; }
    public bool MilestoneCompleted { get; }

    private Milestone(string name, string references, int? parent, string description, bool MilestoneCompleted)
    {
        Name = name;
        References = references;
        Parent = parent;
        Description = description;
        MilestoneCompleted = MilestoneCompleted;
    }

    public class Builder
    {
        public string Name { get; set; }
        public string References { get; set; }
        public int Parent { get; set; }
        public string Description { get; set; }
        public bool MilestoneCompleted { get; set; }

        public Builder SetName(string name)
        {
            Name = name;
            return this;
        }

        public Builder SetReferences(string references)
        {
            References = references;
            return this;
        }

        public Builder SetParent(int parent)
        {
            Parent = parent;
            return this;
        }

        public Builder SetDescription(string description)
        {
            Description = description;
            return this;
        }

        public Builder SetMilestoneCompleted(bool isMilestoneCompleted)
        {
            MilestoneCompleted = isMilestoneCompleted;
            return this;
        }

        public Milestone Build()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new InvalidOperationException("Name must be set");

            return new Milestone(Name, References, Parent, Description, MilestoneCompleted);
        }
    }
}