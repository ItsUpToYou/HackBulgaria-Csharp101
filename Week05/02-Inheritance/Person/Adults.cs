using System.Collections.Generic;

namespace Person
{
    public class Adults : Person
    {
        public List<Child> Children { get; set; }

        public Adults(List<Child> ch)
        {
            this.Children = ch;
        }

        public override string Doing()
        {
            return "Work";
        }

    }
}
