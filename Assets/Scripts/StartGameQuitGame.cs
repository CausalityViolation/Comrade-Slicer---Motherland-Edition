using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameQuitGame : MonoBehaviour
{

    public AudioSource clickSound;

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
        clickSound.Play();
    }

    public void QuitGame()
    {
        Application.Quit();
        clickSound.Play();
    }
}
