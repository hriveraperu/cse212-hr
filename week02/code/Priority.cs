using System.Security.Cryptography;

public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.
        // The Dequeue function shall remove the item with the highest priority and return its value.
        // Expected Result: [Data 1 (Pri:1), Data 2 (Pri:50), Data 3 (Pri:10)], Data 2, Data 3, Data 1
        Console.WriteLine("Test 1");
        var pq = new PriorityQueue();
        pq.Enqueue("Data 1", 1);
        pq.Enqueue("Data 2", 50);
        pq.Enqueue("Data 3", 10);
        Console.WriteLine(pq);
        pq.Dequeue();
        pq.Dequeue();
        pq.Dequeue();

        // Defect(s) Found: The Dequeue is not taking out items

        Console.WriteLine("---------");

        // Test 2
        // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
        // Expected Result: Data 1, Data 2, Data 4
        Console.WriteLine("Test 2");
        pq = new PriorityQueue();
        pq.Enqueue("Data 1", 10);
        pq.Enqueue("Data 2", 10);
        pq.Enqueue("Data 3", 5);
        pq.Enqueue("Data 4", 10);
        
        pq.Dequeue();
        pq.Dequeue();
        pq.Dequeue();
        // Defect(s) Found: The Dequeue was taking out items from last because of a ">=" so when multiple items have the same 
        // value, it would take out the last, so it was changed to ">" so the first would be considered

        Console.WriteLine("---------");

        // Test 3
        // Scenario: If the queue is empty, then an error message will be displayed.
        // Expected Result: Error x 3
        Console.WriteLine("Test 3");
        pq = new PriorityQueue();
        pq.Dequeue();
        pq.Dequeue();
        pq.Dequeue();
        // Defect(s) Found: None =)
    }
}