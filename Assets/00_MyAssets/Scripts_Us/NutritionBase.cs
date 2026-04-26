using UnityEngine;

public abstract class NutritionBase : MonoBehaviour //add IEffects weather stuff later?
{
    [SerializeField] float addHP;
    [SerializeField] float appearance;
    [SerializeField] float spawnRate;

    public abstract void AddHealth(int v);
    public abstract void CheckWeather();

    void Update()
    {

    }

}
