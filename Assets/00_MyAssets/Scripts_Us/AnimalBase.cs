using System.Data.Common;
using UnityEngine;

public class AnimalBase : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    [SerializeField] float moveSpeed;
    [SerializeField] float attackDamage;
    [SerializeField] float giveUpTimer;

    DoDamage(float attackDamage);

    public class Cat : AnimalBase 
    {
        
        DoDamage();

    }
        

    // Update is called once per frame
    void Update()
    {
        
    }
}
