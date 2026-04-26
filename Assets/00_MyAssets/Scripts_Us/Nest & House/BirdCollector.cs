using UnityEngine;

public class BirdCollector : MonoBehaviour
{
    //stores how many sticks the bird is currently carrying
    //kept private to protect the data (Encapsulation)
    private int carriedSticks = 0;

    //returns current number of sticks
    //used by other scripts (like Nest)
    public int GetCarriedSticks()
    {
        return carriedSticks;
    }

    //adds one stick when bird picks up a collectible
    public void PickUpStick()
    {
        carriedSticks++;

        //prints info to console for testing
        Debug.Log("Bird picked up a stick. Carrying: " + carriedSticks);
    }

    //removes all sticks after delivering to nest
    public void RemoveAllSticks()
    {
        carriedSticks = 0;
    }

    //Source: Unity OnTriggerEnter + GetComponent
    private void OnTriggerEnter(Collider other)
    {
        //tries to find a CollectibleItem component on the object
        CollectibleItem item = other.GetComponent<CollectibleItem>();

        //if the object is a collectible item
        if (item != null)
        {
            //calls its Collect() method
            //this uses polymorphism (different items can behave differently)
            item.Collect(this);
        }
    }
}