using UnityEngine;
using UnityEngine.UIElements;

public class Insect : AnimalBase

{
    public GameObject insectPrefab;
    [SerializeField] private float spinSpeed = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        insectPrefab.transform.Rotate(0, 0, spinSpeed);
    }
}

   

