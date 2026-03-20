using System.Data.Common;
using UnityEngine;

public abstract class AnimalBase : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    [SerializeField] float moveSpeed;
    [SerializeField] float attackDamage;
    [SerializeField] float giveUpTimer;
    [SerializeField] float animalHealth;

    public abstract void DoDamage(int amount);

    public virtual void DoDamageToNest(int amount)
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
