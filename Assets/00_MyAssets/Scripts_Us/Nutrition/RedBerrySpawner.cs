using NUnit.Framework.Constraints;
using UnityEngine;

/*
 * Code Grave Yard
 * 
 * This was made near the beginning of the project
 * Decided to make SpawnManager after 'learning better' from
 * Unity's Junior Programmer
 * It makes more sense for us to have a SpawnManager
 * also because it helps us avoid rewriting code to get
 * info from WeatherManager
 * 
 */
public class RedBerrySpawner : NutritionBase
{
    public override void AddHealth(int v)
    {
        throw new System.NotImplementedException();
    }

    public override void CheckWeather()
    {
        throw new System.NotImplementedException();
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        CheckWeather();

        AddHealth(5);



    }
}
