using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TableScript : MonoBehaviour
{
    public void PlayGame () 
    {
        Debug.Log("Reached table scene");
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 2);
    }
    
    public void QuitGame ()
    {
        Debug.Log ("QUIT!");
        Application.Quit();
    }
}
