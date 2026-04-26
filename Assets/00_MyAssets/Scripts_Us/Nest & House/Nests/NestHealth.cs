using UnityEngine;

public class NestHealth : MonoBehaviour
{
    public float nestMaxHealth;
    public float nestCurrentHealth;

    public Vector3 originalNestSize;
    public float nestHealth = 1f;
    private bool nestLost = false;
    public Transform nestVisual; // the child object

    void Start()
    {
        originalNestSize = nestVisual.localScale; /* with transform it resized the nest in a weird way, was gone after one hit, that are registered as several.
                                                   * Now it resizes only the visual part of the nest, the collider stays the same size in the parent.*/
    }
    public void TakeDamage(float amount) // this is for the cat's damage to the nest
    {
        if (nestLost == false)
        { 
            nestCurrentHealth -= amount; // cat damages nest at a certain amount
        }
        if (nestCurrentHealth <= 0f)
        {
            nestCurrentHealth = 0f;
            nestLost = true;
           // Debug.Log("Nest Lost");
        }
        float healthPercent = nestCurrentHealth / (float) nestMaxHealth;
        nestVisual.localScale = originalNestSize * healthPercent;  /* with transform it resized the nest in a weird way, was gone after one hit, that are registered as several.
                                                                    * Now it resizes only the visual part of the nest, the collider stays the same size in the parent.*/
        
        
    }
}



