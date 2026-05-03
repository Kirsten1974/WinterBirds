using UnityEngine;

public abstract class NutritionBase : MonoBehaviour //add IHeal?
{
    [SerializeField] float addHP;
    [SerializeField] float appearance;
    //[SerializeField] float spawnRate; ?? Or better done in SpawnManager?

    public abstract void AddHealth(int v);
    public abstract void CheckWeather();

    void Update()
    {

    }

}
