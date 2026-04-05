using UnityEngine;

public class RedBird : Bird
{
    public override void Fly()
    {
        transform.position += Vector3.forward * 1f;
        Debug.Log("Red bird flies forward 1m");
    }
}