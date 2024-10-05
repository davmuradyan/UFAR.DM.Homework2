using UFAR.DM.Homework2;

CustomQueue<int> queue = new CustomQueue<int>(2);
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);

queue.Dequeue();
queue.Dequeue();
queue.Enqueue(5);
queue.Enqueue(6);
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();

int[] a = [1,3,5,5,4];
SelectionSort.Sort(ref a);

foreach (int i in a) {
    Console.WriteLine(i);
}

a = [1, 3, 5, 5, 4];

InsertionSort.Sort(ref a);

foreach (int i in a) {
    Console.WriteLine(i);
}