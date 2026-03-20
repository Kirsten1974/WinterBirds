using UnityEngine;

public abstract class AnimalBase : MonoBehaviour, IDamageable
{
    int animalHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public abstract void DoDamage(int amount);

    public virtual void DoDamageToNest(int amount)
    {

    }
}
