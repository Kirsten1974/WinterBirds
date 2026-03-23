using UnityEngine;

public interface IEffects
{
    public abstract void EffectWeather(); //rain, sunny...etc.  if rain, more worm spawn + no cats
    public abstract void EffectTemperature(); //affects nutritional spawns
    public abstract void EffectWindSpeed();
    public abstract void EffectTimeOfDay();

}
