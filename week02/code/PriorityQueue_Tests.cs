using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Remove the value with the highest priority.
    // Expected Result: Boikanyo 
    // Defect(s) Found: The loop was not running through all values in the for loop, had to remove '-1' 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bonolo", 1);
        priorityQueue.Enqueue("Boiketlo", 2);
        priorityQueue.Enqueue("Boikanyo", 3); 

        Assert.AreEqual("Boikanyo", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add values to the queue and dequeue them in order of priority.
    // Expected Result: Boikanyo, Boiketlo, Bonolo
    // Defect(s) Found: Item with highest priority was not removed in Dequeue function, just returned
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Boiketlo", 2);
        priorityQueue.Enqueue("Boikanyo", 3); 
        priorityQueue.Enqueue("Bonolo", 1);

        Assert.AreEqual("Boikanyo", priorityQueue.Dequeue());
        Assert.AreEqual("Boiketlo", priorityQueue.Dequeue());
        Assert.AreEqual("Bonolo", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: There are multiple values with the same high priority, so the first one (following the FIFO strategy) is removed first.
    // Expected Result: Bontle, Boiketlo
    // Defect(s) Found: Found that I need to remove = sign in Dequeue() function in the if statement inside my for loop
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Boikanyo", 3); 
        priorityQueue.Enqueue("Bonolo", 1);
        priorityQueue.Enqueue("Boiketlo", 2);
        priorityQueue.Enqueue("Bontle", 3);
       
        Assert.AreEqual("Bontle", priorityQueue.Dequeue());
        Assert.AreEqual("Boikanyo", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Trying to dequeue from an empty queue
    // Expected Result: InvalidOperationException with a message of "The queue is empty."
    // Defect(s) Found: None
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
       try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
}