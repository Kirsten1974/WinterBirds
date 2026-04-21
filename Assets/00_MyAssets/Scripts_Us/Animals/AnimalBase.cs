using JetBrains.Annotations;
using System.Data.Common;
using UnityEngine;
using UnityEngine.Events;

public abstract class AnimalBase : MonoBehaviour //,IEffects
{

    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float attackDamage;
    [SerializeField] protected float giveUpTimer;
    [SerializeField] protected float animalHealth;
    [SerializeField] protected float spawnRate;

}

public abstract class Enemy : AnimalBase, IDoDamage

{
    public abstract void Activity(); //how it moves/responds to the heavens

    public abstract void TargetPlayer(); //moves toward player when within area
    
    //Interface
    public abstract void DoDamage(float attackDamage);
    public abstract void DoDamageToNest(NestHealth nest, float amount);

    public class TriggerWithTag : MonoBehaviour
    {
        public string tagToCheck = "Player";
        public UnityEvent onTriggerEvent;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(tagToCheck))
            {
                Debug.Log($"hit {tagToCheck}");
                // You can do here things you want to trigger
                onTriggerEvent.Invoke();
            }
        }
    }


}