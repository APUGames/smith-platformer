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

    public void ContinueGame()
    {
        SceneManager.LoadScene(2); //story cutscene
    }

    public void Collectibles()
    {
        SceneManager.LoadScene(4); //Collectibles cutscene
    }

    public void Quit()
    {
        Application.Quit();
    }
}
