using UnityEngine;

public class RotateTheLight : MonoBehaviour
{
    
    public float degreeInSec = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * degreeInSec * Time.deltaTime); /*wrote this only for proof of concept. It does the same thing the
                                                                        DayAndNight-script does, it rotates an object around the x axis at a 
                                                                        certain speed, just way simpler */
    }
}
