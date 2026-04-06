using UnityEngine;

public class TestBird : MonoBehaviour
{
    public Bird bird;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bird.Fly();
        }
    }
}