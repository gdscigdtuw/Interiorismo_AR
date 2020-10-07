using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScriptTiles : MonoBehaviour
{
    public void PlayGame () 
    {
        Debug.Log("Reached sofa scene");
        SceneManager.LoadScene (1);
    }
}
