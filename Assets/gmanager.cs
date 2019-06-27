using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gmanager : MonoBehaviour
{
    // Start is called before the first frame update
    bool gamehasended = false;


    public void Endgame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("Gameover");
            Invoke("restart", 1f);
        }
    
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    
}
