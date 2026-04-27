using UnityEngine;

public class Insect : AnimalBase

{
    public GameObject lake;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Activity();   
    }

    public override void Activity()
    {
        //Fly will 'rotate around' the lake's position
        //moveSpeed in this case is the degrees/sec
        //Flies "around" in circles
        transform.RotateAround(lake.transform.position, Vector3.up, moveSpeed * Time.deltaTime);
        //has food tag
        //add IHeal
    }
}
