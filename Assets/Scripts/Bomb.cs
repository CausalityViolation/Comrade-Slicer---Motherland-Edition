using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Blade blade = collision.GetComponent<Blade>();

        if (!blade)
        {
            return;
        }
        else
        {
            FindObjectOfType<GameManager>().OnBombHit();
        }
    }
}
