using UnityEngine;

public class WeatherManager : MonoBehaviour
{
    public static float rainShower = 1f;
    bool isRaining;
   
    //RainSettings
    [SerializeField] public GameObject rainPrefab;

//    [SerializeField] public float rainSpawnRate = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //InvokeRepeating("UpdateWeather", 5f, 5f);//checks if raining every 5 seconds
        //InvokeRepeating("SpawnRain", 2f, 0.1f); //spawns rain every 1 second
    }

    // Update is called once per frame
    void Update()
    {
        SpawnRain();
    }

    //void UpdateWeather()
    //{
    //    isRaining = IsRain();
    //}
    
    //public bool IsRain() //is it raining, yes or no?
    //{
    //    bool isRain = false;
    //    int weather = Random.Range(0, 2);

    //    if (weather == 0)
    //    {
    //        isRain = false; //no showers
    //    }
    //    else
    //    {
    //        isRain = true; //rain shower;
    //    }
    //    return isRain;
    //}
    void SpawnRain()
    {
        float xArea = 40;
        float zArea = 40f;
        float yArea = 40f;

        //if (isRaining)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-xArea, xArea), yArea, Random.Range(-zArea, zArea));
            
            Instantiate(rainPrefab, spawnPos, rainPrefab.transform.rotation);

        }

    }
    public void EffectTimeOfDay() //night or day
    {

    }

}
