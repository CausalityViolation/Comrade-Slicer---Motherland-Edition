using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject slicedFruitPrefab;


    public void CreateSlicedFruit()
    {
        GameObject instance = (GameObject)Instantiate(slicedFruitPrefab, transform.position, transform.rotation);

        Rigidbody[] rigidbodiesSliced = instance.transform.GetComponentsInChildren<Rigidbody>();


        foreach (Rigidbody fruit in rigidbodiesSliced)
        {
            fruit.transform.rotation = Random.rotation;
            fruit.AddExplosionForce(Random.Range(500, 800), transform.position, 5f, Random.Range(-3, 3));
        }

        FindObjectOfType<GameManager>().IncreaseScore();

        Destroy(instance.gameObject, 5);
        Destroy(gameObject);


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Blade blade = collision.GetComponent<Blade>();
        if (!blade)
        {
            return;
        }
        else
        {
            FindObjectOfType<PlaySoundEffect>().PlayFruitCutSound();
            CreateSlicedFruit();
        }

    }

}
