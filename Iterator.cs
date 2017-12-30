using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
    public class Iterator
    {
        private string[] values;
        private int position;

        public Iterator(string[] values) {
            this.values = values;
            this.position = -1;
        }

        public bool moveNext() {
           if(this.position >= this.values.Length)
            {
                throw new InvalidOperationException();
            }

            this.position++;
            return this.position < this.values.Length;
        }

        public string current
        {
            get
            {
                try { return this.values[this.position]; }
                catch(Exception)
                {
                    throw new InvalidOperationException();
                }
                
            }
        }
    }
}
