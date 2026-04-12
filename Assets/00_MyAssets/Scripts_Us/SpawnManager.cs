using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] nutritionPrefabs; //allows us to add nutrition prefabs
    public GameObject[] enemyPrefabs; //allows us to add enemy prefabs


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //random range for all nutrition prefabs
        int nutritionIndex = Random.Range(0, nutritionPrefabs.Length);
        //random range for all nutrition prefabs
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);

        Instantiate(nutritionPrefabs[nutritionIndex]); //spawns nutrition
        Instantiate(enemyPrefabs[enemyIndex]); //spawns enemies

    }
}
