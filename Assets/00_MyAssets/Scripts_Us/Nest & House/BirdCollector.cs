using UnityEngine;

public class BirdCollector : MonoBehaviour
{
    private int carriedSticks = 0;

    public int GetCarriedSticks()
    {
        return carriedSticks;
    }

    public void PickUpStick()
    {
        carriedSticks++;
        Debug.Log("Bird picked up a stick. Carrying: " + carriedSticks);
    }

    public void RemoveAllSticks()
    {
        carriedSticks = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        CollectibleItem item = other.GetComponent<CollectibleItem>();

        if (item != null)
        {
            item.Collect(this);
        }
    }
}