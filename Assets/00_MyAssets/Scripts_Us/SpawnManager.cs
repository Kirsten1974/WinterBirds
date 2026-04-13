using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEditor.UIElements;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //nutrition and enemey Settings
    public GameObject[] nutritionPrefabs; //allows us to add nutrition prefabs
    public GameObject[] enemyPrefabs; //allows us to add enemy prefabs


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2, 10);
    }

    // Update is called once per frame
    void Update()
    {

        //random range for all nutrition prefabs

        //random range for all nutrition prefabs
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);



        // changed to "invoke" in start
        // Instantiate(enemyPrefabs[enemyIndex]); //spawns enemies

    }




    void SpawnEnemy()
    {
        int landXRange = 20;
        int landZRange = 20;

        //Randomly generates enemy index and spawn position
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-landXRange, landXRange), 0, Random.Range(-landZRange, landZRange));

        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }


}
