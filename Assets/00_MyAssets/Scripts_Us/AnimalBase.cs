using JetBrains.Annotations;
using System.Data.Common;
using UnityEngine;

public abstract class AnimalBase : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float attackDamage;
    [SerializeField] protected float giveUpTimer;
    [SerializeField] protected float animalHealth;
    [SerializeField] protected float spawnRate;

  
    public abstract void DoDamage(float amount);

    public abstract void DoDamageToNest(float amount);

    // Update is called once per frame
    void Update()
    {
        
    }
}
