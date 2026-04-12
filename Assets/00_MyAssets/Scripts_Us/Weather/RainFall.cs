using UnityEngine;

public class RainFall : MonoBehaviour
{
    //This script is just to control 1 droplet of rain

    [SerializeField] private float baseSpeed = 10f; //rainfall base speed


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float finalSpeed = baseSpeed * WeatherManager.rainShower;
        //rainfalls downwards motion
        transform.Translate(Vector3.down * Time.deltaTime * finalSpeed);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
