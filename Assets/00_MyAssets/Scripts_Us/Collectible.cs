using UnityEngine;

public class Collectible : MonoBehaviour

    /*This script was added from Sab GE collectible
     * allows collectible object to rotate
     * upon collection:
     *      -object is destroyed
     *      -starts particle effect (poof!)
     *      -plays collection sound */


{

    public float rotationSpeed; //input rotationSpeed in Inspector
    public GameObject onCollectEffect;
    //public AudioClip collectSound;
    bool collect = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Destroy the collectible
        Destroy(gameObject);
        //collectEffect particle effect
        if (collect) return;
        collect = true;
        {

            //AudioSource.PlayClipAtPoint(collectSound, transform.position);
            Instantiate(onCollectEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(onCollectEffect);
        }

        //Instantiate(collectSound);
    }
}
