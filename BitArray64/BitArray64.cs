using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray64
{
    public class BitArray64 : IEnumerable<int>
    {
        private ulong bitArray;

        public ulong BitArray {
            get
            {
                return this.bitArray;
            }
            private set
            {
                this.bitArray = value;
            }
        }

        public BitArray64(ulong bitArr)
        {
            this.BitArray = bitArr;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return (int)(this.bitArray >> i) & 1;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
