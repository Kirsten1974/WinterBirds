using UnityEngine;

public class Cat : AnimalBase
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DoDamageToNest(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void DoDamage(int amount)
    {
        throw new System.NotImplementedException();
    }

    public override void DoDamageToNest(int amount)
    {
        base.DoDamageToNest(amount);

        // Add extra functionality.
    }
}
