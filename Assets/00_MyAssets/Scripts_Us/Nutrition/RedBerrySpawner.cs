using NUnit.Framework.Constraints;
using UnityEngine;

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
