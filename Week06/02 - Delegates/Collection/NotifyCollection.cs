using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public delegate void ChangedEventHandler(object sender, NotifyArgs e);

    public class NotifyCollection : ArrayList
    {
        public event ChangedEventHandler CollectionChanged;

        public override int Add(object value)
        {
            int i = base.Add(value);
            string msg = string.Format("Added new value={0} in the collection", value);
            NotifyArgs msgNotify = new NotifyArgs(msg);
            this.OnChanged(msgNotify);
            return i;
        }

        public override void Clear()
        {
            base.Clear();
            string message = string.Format("Collection has cleared!");
            NotifyArgs messageNotify = new NotifyArgs(message);
            this.OnChanged(messageNotify);
        }

        public override object this[int index]
        {
            set
            {
                string message = string.Format("The value of index {0}=({1}) has change to: {2}", index, this[index], value);
                NotifyArgs messageNotify = new NotifyArgs(message);
                base[index] = value;
                this.OnChanged(messageNotify);
            }
        }

        private void OnChanged(NotifyArgs message)
        {
            if (this.CollectionChanged != null)
            {
                this.CollectionChanged(this, message);
            }
        }
    }
}
