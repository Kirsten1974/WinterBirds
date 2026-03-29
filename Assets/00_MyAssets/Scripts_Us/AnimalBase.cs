using JetBrains.Annotations;
using System.Data.Common;
using UnityEngine;

public abstract class AnimalBase : MonoBehaviour , IEffects
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float attackDamage;
    [SerializeField] protected float giveUpTimer;
    [SerializeField] protected float animalHealth;
    [SerializeField] protected float spawnRate;


    //void EffectWeather(); //rain, sunny...etc.  if rain, more worm spawn + no cats
    //void EffectTemperature(); //affects nutritional spawns
    //void EffectWindSpeed();
    //void EffectTimeOfDay();
    public abstract void DoDamage(float amount);

    public abstract void DoDamageToNest(float amount);

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EffectTemperature()
    {
        throw new System.NotImplementedException();
    }

    public void EffectWindSpeed()
    {
        throw new System.NotImplementedException();
    }

    public void EffectTimeOfDay()
    {
        throw new System.NotImplementedException();
    }

    void IEffects.EffectWeather()
    {
        throw new System.NotImplementedException();
    }
}
