using UnityEngine;

public class DayAndNight : MonoBehaviour
{
   Vector3 rotation = Vector3.zero;
    public float degreepersec = 0f; // speed of rotation can be set in Inspector

    // Update is called once per frame
    void Update()
    {
        rotation.x = degreepersec * Time.deltaTime; 
        transform.Rotate(rotation, Space.World); //rotates the directional light
    }
}
