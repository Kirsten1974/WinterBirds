using UnityEngine;

public interface IDoDamage
{
    /*not fully implemented yet
     *Different ways/values to damage player vs nest 
     *Interface because can be assigned beyond enemy class
     *      for example:  to rain fall/hail in the future to 'damage nest'
     *      Created by both after consideration of what parameters
     *      may be given, eg: attackDamage from enemy class                
    */

    public abstract void DoDamage(float attackDamage); 
    public abstract void DoDamageToNest(NestHealth nest, float amount);

}
