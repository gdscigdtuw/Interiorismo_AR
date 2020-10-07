using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FurnitureMenu : MonoBehaviour
{
    public void PlayGame () 
    {
        Debug.Log("Reached chair scene");
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
    }
    
    public void QuitGame ()
    {
        Debug.Log ("QUIT!");
        Application.Quit();
    }
}
