using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   
public class MainMenu : MonoBehaviour
{
    public void OnPlayHandler()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void OnExitHandler()
    {
        Debug.Log("Игра заакрылась.");
        Application.Quit();
    }
}
