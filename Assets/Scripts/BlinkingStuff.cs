using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingStuff : MonoBehaviour
{
   
    public IEnumerator Blink()
    {
        while (true)
        {
            Camera.main.GetComponent<Camera>().backgroundColor = Color.green;
            yield return new WaitForSeconds(0.1f);
            Camera.main.GetComponent<Camera>().backgroundColor = Color.red;
            yield return new WaitForSeconds(0.1f);
            Camera.main.GetComponent<Camera>().backgroundColor = Color.blue;
            yield return new WaitForSeconds(0.1f);
            Camera.main.GetComponent<Camera>().backgroundColor = Color.magenta;
            yield return new WaitForSeconds(0.1f);
            Camera.main.GetComponent<Camera>().backgroundColor = Color.cyan;
            yield return new WaitForSeconds(0.1f);
            Camera.main.GetComponent<Camera>().backgroundColor = Color.yellow;
            yield return new WaitForSeconds(0.1f);

        }
    }

    public void StartBlinking()
    {
        StartCoroutine("Blink");
    }


}
