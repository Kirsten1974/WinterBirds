using UnityEngine;

public class BlueBird : Bird
{
    public override void Fly()
    {
        transform.position += Vector3.up * 1f;
        Debug.Log("Blue bird flies up 1m");
    }
}
