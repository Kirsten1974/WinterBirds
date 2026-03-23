using UnityEngine;

public class Nesting : MonoBehaviour
{
    float nestHealth = 1.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (nestHealth > 0f)
        {
            nestHealth = nestHealth - Time.deltaTime;
            Debug.Log("Nest health is" + nestHealth);

        }
        else 
        { 
            Destroy(gameObject); 
        }
    }
}

