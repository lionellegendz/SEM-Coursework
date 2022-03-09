using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayB : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
