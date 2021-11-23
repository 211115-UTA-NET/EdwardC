// See https://aka.ms/new-console-template for more information

static void Main(){
    // Create List
    List<int> intList = new List<int>();

    // Add List
    intList.Add(5);
    intList.Add(7);
    intList.Add(9);
    intList.Add(3);

    Console.WriteLine("Add List:");
    PrintList(intList);

    // Remove List
    intList.RemoveAt(1);
    intList.RemoveAt(2);

    Console.WriteLine("\nAfter Remove");
    PrintList(intList);

    // insert in specify index
    intList.Insert(0, 11);

    Console.WriteLine("\nInsert into specify index");
    PrintList(intList);

    Console.WriteLine("\nSort List");
    intList.Sort();
    PrintList(intList);

    Console.WriteLine("\nReverse List");
    intList.Reverse();
    PrintList(intList);

    Console.WriteLine("\nFind the element");
    int index = intList.IndexOf(5);
    Console.WriteLine("Value at position: " + index);

    Console.WriteLine("\nGet properties");
    int count = intList.Count;
    int capacity = intList.Capacity;
    Console.WriteLine("Count is {0}, and Capacity is {1}", count, capacity);

    Console.WriteLine(intList[2]);

}

static void PrintList(List<int> list){
    for(int i = 0; i < list.Count; i++){
        Console.WriteLine(list[i]);
    }
}

Main();
