using JetBrains.Annotations;
using System.Data.Common;
using UnityEngine;


/* C
 * 
 * 
 */
public abstract class AnimalBase : MonoBehaviour //this class has all the 'what' for all animals
{

    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float giveUpTimer;
    [SerializeField] protected float animalHealth;
    //[SerializeField] protected float spawnRate; //moved to Spawn Manager

    public abstract void Activity();

}

public abstract class Enemy : AnimalBase //, IDoDamage //Still needs IDoDamage implementation
{
    [SerializeField] protected float attackDamage;

    public abstract void TargetPlayer(); //chases player, Sab

}