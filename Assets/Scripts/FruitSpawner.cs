using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject[] fruits;
    public GameObject bomb;
    public float minDelay = 0.3f;
    public float maxDelay = 1f;
    public Transform[] spawnPlaces;

    public void Start()
    {
        StartCoroutine(SpawnFruits());
    }

    private IEnumerator SpawnFruits()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));

            Transform location = spawnPlaces[Random.Range(0, spawnPlaces.Length)];
            float random = Random.Range(0, 100);



            GameObject objectToSpawn;
            if (random <= 7)
            {
                bomb.transform.rotation = Random.rotation;
                objectToSpawn = bomb;

            }
            else
            {
                objectToSpawn = fruits[Random.Range(0, fruits.Length)];

            }



            GameObject fruit = Instantiate(objectToSpawn, location.position, location.rotation);

            fruit.GetComponent<Rigidbody2D>().AddForce(fruit.transform.up * Random.Range(7, 15), ForceMode2D.Impulse);

            Destroy(fruit, 5);
        }
    }
}
