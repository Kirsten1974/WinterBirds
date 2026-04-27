using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Cat : Enemy 
{
    [SerializeField] private float damage = 1f;
    public NestHealth nest;
    [SerializeField] private WeatherManager manager; 
    
    private GameObject player;
    private PlayerDetecter playerDetecter;

    void Start()
    {
        //findweather weathermanager //association
        manager = FindFirstObjectByType<WeatherManager>(); //communicates with WeatherManager
        //helps find the target (player)
        player = GameObject.FindGameObjectWithTag("Player");
        //makes cat detect the player
        playerDetecter = FindFirstObjectByType<PlayerDetecter>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if the player is around, target it (move towards), otherwise walk around
        if (playerDetecter.playerDetecter) {TargetPlayer();} else {Activity();}

    }

    public override void Activity() //poly
    {
        //if (WeatherManager.day == false;)
        //bool day = EffectTimeOfDay.day(true);

        if (!manager.day) //cat moves at night
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed); //moves around
        }


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


    //if no ground, no cat, else instantiate.

        // Start is called once before the first execution of Update after the MonoBehaviour is created

    public override void TargetPlayer()
    {
        
        //Source: Junior Programmer 4.2
        if (!manager.day)
        {
            //makes cat changes its position by
            //looking at own current position, players position, moves towards player @ deltaTime
            transform.position = Vector3.MoveTowards
                (transform.position, player.transform.position, moveSpeed * Time.fixedDeltaTime); 
            //ChatGPT recommended adding fixed
            //looked up UnityAPI for MoveTowards info, also recommended fixedDeltaTime
            
        }
        
    }
    public void DoDamage(float attackDamage)
    {
        throw new System.NotImplementedException();
    }

    public void DoDamageToNest(NestHealth nest, float amount)
    {
        nest.TakeDamage(amount);

        // Add extra functionality.
    }
}