using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    private GameObject lastAlphabetPointer;
    private int index;

    private PlacementIndicator placementIndicator;
    ObjectPooler OP;

    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
        

    }

    void Awake()
    {
        OP = ObjectPooler.SharedInstance;
    }

    /*  void Update()
      {
          if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
          {
              GameObject obj = Instantiate(objectToSpawn, 
                  placementIndicator.transform.position, placementIndicator.transform.rotation);

          }

      } */

    public void Activate(GameObject objectPrefab)
    {

        //GameObject obj = Instantiate(objectPrefab,
                //placementIndicator.transform.position, placementIndicator.transform.rotation);
        if(lastAlphabetPointer == null)
        {
            GameObject obj = Instantiate(objectPrefab,
              placementIndicator.transform.position, placementIndicator.transform.rotation);
            lastAlphabetPointer = obj;
        }
        
        else
        {
            lastAlphabetPointer.SetActive(false);
            GameObject obj = Instantiate(objectPrefab,
                placementIndicator.transform.position, placementIndicator.transform.rotation);
            lastAlphabetPointer = obj;
        }
    }


}