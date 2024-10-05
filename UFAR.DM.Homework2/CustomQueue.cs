using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFAR.DM.Homework2 {
    public class CustomQueue<T> {
        private uint defaultSize = 4;
        private uint size = 0;
        private T[] queue;

        public CustomQueue(uint size = 4) {
            defaultSize = size;
            queue = new T[size];
        }

        public void Enqueue(T item) {
            size++;
            if (size >= defaultSize)
            {
                Array.Resize(ref queue, (int)defaultSize + 4);
                defaultSize += 4;
            }
            queue[size-1] = item;
        }

        public T Dequeue() {
            if (size == 0)
            {
                throw new Exception("The queue is empty!");
            }

            T returnItem = queue[0];
            for (uint i = 0; i < size-1; i++) {
                queue[i] = queue[i + 1];
            }
            queue[size - 1] = default;
            size--;

            if (defaultSize - size >= 4)
            {
                Array.Resize(ref queue, (int)defaultSize - 4);
                defaultSize -= 4;
            }

            return returnItem;
        }
    }
}
