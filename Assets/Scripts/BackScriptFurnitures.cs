using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScriptFurnitures : MonoBehaviour
{
    public void PlayGame () 
    {
        Debug.Log("Reached sofa scene");
        SceneManager.LoadScene (2);
    }
}
