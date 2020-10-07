using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScriptOptions : MonoBehaviour
{
    public void PlayGame () 
    {
        SceneManager.LoadScene (0);
    }
}
