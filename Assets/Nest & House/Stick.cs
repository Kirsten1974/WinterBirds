using UnityEngine;

public class Stick : CollectibleItem
{
    public override void Collect(BirdCollector bird)
    {
        bird.PickUpStick();
        Destroy(gameObject);
    }
}