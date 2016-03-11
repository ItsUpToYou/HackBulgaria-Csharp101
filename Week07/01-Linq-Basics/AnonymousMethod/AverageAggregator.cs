using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace AnonymousMethod
{
    public class AverageAggregator : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double average;

        private readonly List<int> nums = new List<int>();

        public double Average
        {
            get
            {
                return this.average;
            }
            set
            {
                if (this.average != value && this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Average"));
                }
                this.average = value;
            }
        }

        public void AddNumber(int num)
        {
            this.nums.Add(num);
            this.Average = this.nums.Average();
        }

    }
}
