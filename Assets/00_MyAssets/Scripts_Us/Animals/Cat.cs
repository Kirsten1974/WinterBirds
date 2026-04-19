using UnityEngine;

public class Cat : AnimalBase //IEffects
{
    public float damage = 1f;
    public NestHealth nest;
    public Transform sun; //if rotation range = x-xxy, cat leaves else stays around
    public bool day = true;
    public override void DoDamage(float amount)
    {
        throw new System.NotImplementedException();
    }

    public override void DoDamageToNest(NestHealth nest, float amount)
    {
        nest.TakeDamage(amount); 
        
        // Add extra functionality.
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Nest"))
        {
            NestHealth nest = other.GetComponent<NestHealth>();   // AI sugested that as a solution for the problem that cat clones don't do damage

            if (nest != null)
            {
                DoDamageToNest(nest, damage);  //cat and cat clone deal damage to the nest if the nests health is not 0
            }
        }
            /* if (other.CompareTag("Nest"))  // this only worked for the original cat, not the cat clones
             {
                 DoDamageToNest (nest, damage); 
             }*/
        }
   
    //if rain, no cat, else instantiate.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //spawn checker based on weather?
        //DoDamageToNest(0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        float sunRotation = sun.eulerAngles.x; //AI helped with this part, didn't know, what euler.Angles are and such
        Debug.Log(sunRotation);
        if (sunRotation > 160 && sunRotation < 359)
            day = false;                    
        else 
            day = true; 

        if (day == false)               //cat only moves at night (roughly)
        {

            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed); //moves
            // trigger event, if cat in sphere, do damage
            //damagesNest
        }
        
    }


}

