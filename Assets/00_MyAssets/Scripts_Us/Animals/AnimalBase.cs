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


    public abstract void Activity();

}

public abstract class Enemy : AnimalBase
{
    public abstract void TargetPlayer();
    public abstract void DoDamage(float attackDamage);
    public abstract void DoDamageToNest(NestHealth nest, float amount);

}