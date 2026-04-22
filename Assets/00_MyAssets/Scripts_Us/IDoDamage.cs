using UnityEngine;

public interface IDoDamage
{
    public abstract void DoDamage(float attackDamage);
    public abstract void DoDamageToNest(NestHealth nest, float amount);

}
