using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoolScript : MonoBehaviour
{
    public void PlayGame() 
    {
        Debug.Log("Reached Stool scene");
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 6);
    }
}
