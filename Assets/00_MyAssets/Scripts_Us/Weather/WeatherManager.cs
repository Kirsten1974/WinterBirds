using System.Diagnostics.Tracing;
using UnityEngine;

public class WeatherManager : MonoBehaviour
{
    [SerializeField] public static float rainShower = 1.0f;
    public int weather;
    bool isRaining;

    //RainSettings
    [SerializeField] public GameObject rainPrefab;

    void Start()
    {
        //InvokeRepeating("SetRaining", 2f, 5f); //spawns rain every 5 second
        InvokeRepeating(nameof(SetRaining), 2f, 5f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (IsRaining()) SpawnRain();
        if (isRaining) SpawnRain();
    }

    /*
    public bool IsRaining() //is it raining, yes or no?
    {
        if (weather == 0)
        {
            //isRain = false; //no showers
            Debug.Log("It isn't raining");
            return false;
        }
        else
        {
            //isRain = true; //rain shower;
            Debug.Log("It IS raining");         //removed spawn rain
            return true;
        }
    }
    */

    public void SetRaining()  //is it raining? yes or no? //if (WeatherManager.isRaining)
    {
        weather = Random.Range(0, 2);

        if (weather == 0) isRaining = false;
        else isRaining = true;
    }
    void SpawnRain()
    {
        float xArea = 40;
        float zArea = 40f;
        float yArea = 40f;       
        
        Vector3 spawnPos = new Vector3(Random.Range(-xArea, xArea), yArea, Random.Range(-zArea, zArea));

        Instantiate(rainPrefab, spawnPos, rainPrefab.transform.rotation);
        
    }
    public void EffectTimeOfDay() //night or day
    {

    }

}
