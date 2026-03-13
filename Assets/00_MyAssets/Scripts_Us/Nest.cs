using System;
using UnityEngine;

public class Nest : MonoBehaviour

    //want the nest's own health to deteriorate slowly over time
    //nest will provide health to player
{
    [SerializeField] private float nestHealth = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        do
        {
            nestHealth = nestHealth - Time.deltaTime;
            Debug.Log(nestHealth);
        }
        while (nestHealth > 0f);
        


    }
}
