// See https://aka.ms/new-console-template for more information
using Implementation_Deque;

Console.WriteLine("Hello, World!");
Deque obj = new Deque();
obj.EnqueueRear(2);
Console.WriteLine("Rear:"+obj.PeekRear());
Console.WriteLine("Front:"+obj.PeekFront());
Console.WriteLine("Size:" + obj.Size);
Console.WriteLine("-----------------");
obj.EnqueueRear(8);
Console.WriteLine("Rear"+obj.PeekRear());
Console.WriteLine("Front"+obj.PeekFront());
Console.WriteLine("Size:" + obj.Size);
Console.WriteLine("-----------------");
obj.EnqueueFront(10);
Console.WriteLine("Rear"+obj.PeekRear());
Console.WriteLine("Front"+obj.PeekFront());
Console.WriteLine("Size:" + obj.Size);
Console.WriteLine("-----------------");
obj.DequeueRear();
Console.WriteLine("Rear" + obj.PeekRear());
Console.WriteLine("Front" + obj.PeekFront());
Console.WriteLine("Size:" + obj.Size);
Console.WriteLine("-----------------");
obj.EnqueueRear(200);
Console.WriteLine("Rear" + obj.PeekRear());
Console.WriteLine("Front" + obj.PeekFront());
Console.WriteLine("Size:" + obj.Size);
Console.WriteLine("-----------------");
obj.DequeueFront();
Console.WriteLine("Rear" + obj.PeekRear());
Console.WriteLine("Front" + obj.PeekFront());
Console.WriteLine("Size:" + obj.Size);
Console.WriteLine("-----------------");


