using UnityEngine;

public class Cat : AnimalBase, IEffects
{
    public override void DoDamage(float amount)
    {
        throw new System.NotImplementedException();
    }

    public override void DoDamageToNest(float amount)
    {
        DoDamageToNest(amount);

        // Add extra functionality.
    }
    public Transform sun;
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
