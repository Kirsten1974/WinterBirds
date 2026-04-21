using UnityEngine;

public interface IDoDamage 
{
    public abstract void DoDamage(float attackDamage); //damage to player
    public abstract void DoDamageToNest(NestHealth nest, float amount); //damage to shelter

}
