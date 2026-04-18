using UnityEngine;

public class Cat : AnimalBase //IEffects
{
    public float damage = 1f;
    public NestHealth nest;
    public override void DoDamage(float amount)
    {
        throw new System.NotImplementedException();
    }

    public override void DoDamageToNest(float amount) 
    {
       // nest.TakeDamage(amount); 

        // Add extra functionality.
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Nest"))
        {
            NestHealth nest = other.GetComponent<NestHealth>();   // AI sugested that as a solution for the problem that cat clones don't do damage

            if (nest != null)
            {
                nest.TakeDamage(damage);
            }
        }
       /* if (other.CompareTag("Nest"))  // this only worked for the original cat, not the cat clones
        {
            DoDamageToNest (damage); 
        }*/
    }

    public Transform sun;//if rotation range = x-xxy, cat leaves else stays around

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
        //trigger event, if cat in sphere, do damage
        
        //moves
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

        //damagesNest

    }


}

