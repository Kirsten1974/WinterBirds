using UnityEngine;

public class DayAndNight : MonoBehaviour
{
   Vector3 rotation = Vector3.zero;
    public float degreepersec = 0f;

    // Update is called once per frame
    void Update()
    {
        rotation.x = degreepersec * Time.deltaTime;
        transform.Rotate(rotation, Space.World);
    }
}
