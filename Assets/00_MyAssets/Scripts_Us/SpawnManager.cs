using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //landrange
    int landXRange = 20;
    int landZRange = 20;
    //nutrition and enemey Settings
    public GameObject[] nutritionPrefabs; //allows us to add nutrition prefabs
    public GameObject[] enemyPrefabs; //allows us to add enemy prefabs
    //Get info from Weather manager
    [SerializeField] private WeatherManager manager;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = FindFirstObjectByType<WeatherManager>(); //communicates with WeatherManager
        InvokeRepeating(nameof(SpawnEnemy), 1, 5);  // previously InvokeRepeating("SpawnEnemy", 2, 10);
        InvokeRepeating(nameof(SpawnNutrition), 1, 5);  // previously InvokeRepeating("SpawnNutrition", 2, 10);
    }

    // Update is called once per frame
    void Update()
    {

        //random range for all nutrition prefabs
        //int nutritionIndex = Random.Range(0, nutritionPrefabs.Length);
        //random range for all nutrition prefabs
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);



        // changed to "invoke" in start
        // Instantiate(enemyPrefabs[enemyIndex]); //spawns enemies

    }




    void SpawnEnemy()
    {


        //Randomly generates enemy index and spawn position
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-landXRange, landXRange), 3, Random.Range(-landZRange, landZRange));

        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }

    void SpawnNutrition()
    {

        //Randomly generates enemy index and spawn position
        int nutritionIndex = Random.Range(0, nutritionPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-landXRange, landXRange), 3, Random.Range(-landZRange, landZRange));

        Instantiate(nutritionPrefabs[nutritionIndex], spawnPos, nutritionPrefabs[nutritionIndex].transform.rotation);
    }

}
