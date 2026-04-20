using UnityEngine;

public class Cat : Enemy //IEffects
{
    public float damage = 1f;
    public NestHealth nest;
    [SerializeField] private WeatherManager manager;

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
        manager = FindFirstObjectByType<WeatherManager>(); //communicates with WeatherManager

        //findweather manager thingy
    }

    // Update is called once per frame
    void Update()
    {


        Activity();

    }

    public override void Activity() //poly
    {
        //if (WeatherManager.day == false;)
        //bool day = EffectTimeOfDay.day(true);

        if (!manager.day)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed); //moves
                                                                               // trigger event, if cat in sphere, do damage
                                                                               //damagesNest
        }

    }
    public override void TargetPlayer()
    {
        {
            //FROM GE, helps target player, but there is an offset, needs to be fixed for our game
            //Add 'OnTriggerEnter SphereCollider

            //public Transform player;               // Drag your Player here in Inspector
            //public Vector3 offset = new Vector3(0, 0, -0.5f); // Relative position behind player
            //public float followSpeed = 5f;         // How fast the buddy moves

            //private Rigidbody followRb;

            //void Start()
            //{
            //    followRb = GetComponent<Rigidbody>();
            //    // Make sure Rigidbody is kinematic
            //    followRb.isKinematic = true;

            //    // Optional: find player automatically if not assigned
            //    if (player == null)
            //    {
            //        GameObject p = GameObject.Find("Player");
            //        if (p != null) player = p.transform;
            //    }
            //}

            //void FixedUpdate()
            //{

            //    if (player == null) return;

            //    // Calculate the target position relative to the player
            //    Vector3 targetPosition = player.position + offset;

            //    // Move smoothly toward target
            //    Vector3 newPosition = Vector3.Lerp(followRb.position, targetPosition, followSpeed * Time.fixedDeltaTime);

            //    // Move the Rigidbody without physics collisions pushing it
            //    followRb.MovePosition(newPosition);

            //}
        }


    }
}

