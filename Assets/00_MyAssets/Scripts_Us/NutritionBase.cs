using UnityEngine;

public abstract class NutritionBase : MonoBehaviour
{
    [SerializeField] float nutrition;
    [SerializeField] float appearance;
    [SerializeField] float nothin;

    public abstract void AddHealth();
    public abstract void CheckWeather();

    void Update()
    {

    }

}
