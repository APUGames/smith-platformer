using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //Public instead of private because function needs to be accessible by the button
    public void StartGame()
    {
        SceneManager.LoadScene(1); //The Scene after Scene 0 
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(0); //The Scene after Scene 0 
    }
    public void Quit()
    {
        Application.Quit();
    }
}
