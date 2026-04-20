using System.Diagnostics.Tracing;
using UnityEngine;

public class WeatherManager : MonoBehaviour
{
    //SunStuff
    //public GameObject sunPrefab;
    public Transform sun; //if rotation range = x-xxy, cat leaves else stays around
    public bool day; //public because needs to be accessible to other scripts (eg - cats)

    //Rain
    [SerializeField] public static float rainShower = 1.0f;
    public int weather;
    public bool isRaining; //public because needs to be accessible to other scripts (eg - cats)
    [SerializeField] public GameObject rainPrefab;

    void Start()
    {
        //InvokeRepeating("SetRaining", 2f, 5f); //spawns rain every 5 second
        InvokeRepeating(nameof(SetRaining), 2f, 5f);
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        EffectTimeOfDay();
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
        float xArea = 40f;
        float zArea = 40f;
        float yArea = 40f;       
        
        Vector3 spawnPos = new Vector3(Random.Range(-xArea, xArea), yArea, Random.Range(-zArea, zArea));

        Instantiate(rainPrefab, spawnPos, rainPrefab.transform.rotation);
        
    }
    public bool EffectTimeOfDay() //day or night
    {
        float sunRotation = sun.eulerAngles.x; //AI helped with this part, didn't know, what euler.Angles are and such

        //Debug.Log("Sun is at " + sunRotation);  //removed because works
        if (sunRotation > 160 && sunRotation < 359)
        {
            day = false; //it is night
            return day;
        }
        else
        {
            day = true; //it is day
            return day;
        }


        
    }


    }
