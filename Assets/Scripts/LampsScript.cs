using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LampsScript : MonoBehaviour
{
    public void PlayGame () 
    {
        Debug.Log("Reached Lamp scene");
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 5);
    }
    
}
