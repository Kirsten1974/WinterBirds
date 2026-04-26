using UnityEngine;

//abstract base class for all collectible objects
//Source: OOP concept - Abstraction (defines what to do, not how)
public abstract class CollectibleItem : MonoBehaviour
{
    //forces all child classes (like Stick) to implement Collect()
    //this method will be called when the bird interacts with the item
    //BirdCollector is passed in so the item can affect the bird (e.g. add sticks)
    public abstract void Collect(BirdCollector bird);
}