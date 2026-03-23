using UnityEngine;

public interface IConditional
{
    void CreateWeather(); //rain, sunny...etc.  if rain, more worm spawn + no cats
    void SetTemperature(); //affects nutritional spawns
    void SetWindSpeed();
    void SetTimeOfDay();

}
