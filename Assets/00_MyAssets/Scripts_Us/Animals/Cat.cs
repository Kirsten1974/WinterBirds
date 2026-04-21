using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Cat : Enemy //IEffects
{
    public float damage = 1f;
    public NestHealth nest;
    [SerializeField] private WeatherManager manager;

    void Start()
    {

        //spawn checker based on weather?
        //DoDamageToNest(0.1f);
        manager = FindFirstObjectByType<WeatherManager>(); //communicates with WeatherManager

        //findweather manager thingy
    }

    // Update is called once per frame
    void Update()
    {


        Activity();

    }


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

    public override void Activity() //poly
    {
        //if (WeatherManager.day == false;)
        //bool day = EffectTimeOfDay.day(true);

        if (!manager.day)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed); //moves

        }

    }
    public override void TargetPlayer()
    {

      

    }

}


 

