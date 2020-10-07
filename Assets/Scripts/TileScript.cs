using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TileScript : MonoBehaviour
{
    public void PlayGame () 
    {
        Debug.Log("Reached tile scene");
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 8);
    }
}
