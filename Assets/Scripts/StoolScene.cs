using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoolScene : MonoBehaviour
{
    public void PlayGame () 
    {
        Debug.Log("Reached stool scene");
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 6);
    }
}
