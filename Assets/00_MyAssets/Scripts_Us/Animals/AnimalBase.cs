using JetBrains.Annotations;
using System.Data.Common;
using UnityEngine;

public abstract class AnimalBase : MonoBehaviour
{

    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float giveUpTimer;
    [SerializeField] protected float animalHealth;
    //[SerializeField] protected float spawnRate; //moved to Spawn Manager

    public abstract void Activity();

}

public abstract class Enemy : AnimalBase //Still needs IDoDamage
{
    [SerializeField] protected float attackDamage;

    public abstract void TargetPlayer(); //chases player

}