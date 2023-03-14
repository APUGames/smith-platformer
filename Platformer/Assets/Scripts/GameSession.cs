using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    [SerializeField] int playerLives = 3;
    [SerializeField] int playerThread = 0;

    [SerializeField] Text lives;
    [SerializeField] Text threads;

    private void Awake()
    {
        //Find number of similar objects in the Scene
        int numGameSessions = FindObjectsOfType<GameSession>().Length;

        if (numGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            //if scene reloads, singleton wont be destroyed
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        lives.text = playerLives.ToString();
        // Will convert number to text and put it in text box^)

        threads.text = playerThread.ToString();
    }

    public void ProcessPlayerThread(int incomingThreads)
    {
        playerThread += incomingThreads;

        threads.text = playerThread.ToString();   
    }
    
    public void ProcessPlayerDeath()
    {
        if(playerLives > 1)
        {
            SubtractLife();
        }
        else
        {
            ResetGameSession();
        }
    }

    private void SubtractLife()
    {
        playerLives--;

        Debug.Log("Player Lives: " + playerLives);

        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentSceneIndex);

        lives.text = playerLives.ToString();
    }

    private void ResetGameSession()
    {
        SceneManager.LoadScene(0);

        Destroy(gameObject);
    }

}
