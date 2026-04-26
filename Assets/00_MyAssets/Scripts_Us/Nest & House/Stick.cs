using UnityEngine;

//represents a stick that can be collected by the bird
//inherits from CollectibleItem (Inheritance)
public class Stick : CollectibleItem
{
    //overrides the Collect method from the base class
    //Source: OOP Polymorphism (same method, different behavior)
    public override void Collect(BirdCollector bird)
    {
        //adds one stick to the bird
        bird.PickUpStick();

        //destroys the stick object after being collected
        Destroy(gameObject);
    }
}