using JetBrains.Annotations;
using System.Data.Common;
using UnityEngine;

public abstract class AnimalBase : MonoBehaviour //,IEffects
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float attackDamage;
    [SerializeField] protected float giveUpTimer;
    [SerializeField] protected float animalHealth;
    [SerializeField] protected float spawnRate;


    //public void EffectWeather();
    //{   throw new System.NotImplementedException(); 
    
    //void EffectWeather(); //rain, sunny...etc.  if rain, more worm spawn + no cats
    //void EffectTemperature(); //affects nutritional spawns
    //void EffectWindSpeed();
    //void EffectTimeOfDay();
    public abstract void DoDamage(float amount);

    public abstract void DoDamageToNest(NestHealth nest,float amount);

    public void EffectTimeOfDay()
    {
        throw new System.NotImplementedException();
    }

    public void EffectWeather()
    {
        throw new System.NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
