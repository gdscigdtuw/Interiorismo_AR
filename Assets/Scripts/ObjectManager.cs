using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ObjectManager : MonoBehaviour
{
    public GameObject pointer;
    public ARRaycastManager raycastManager;

    Vector2 screenCenter;
    Vector3 groundHitPos;
    GameObject arObject;

    public bool allowMove;

    // Start is called before the first frame update
    void Start()
    {
        screenCenter = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();

        if (raycastManager.Raycast(screenCenter, hits, TrackableType.Planes))
        {
            groundHitPos = hits[0].pose.position;
            pointer.transform.localPosition = groundHitPos;

            if (!pointer.activeSelf)
            {
                pointer.SetActive(true);
            }
        }

        if (allowMove && groundHitPos!=null && arObject != null)
        {
            arObject.transform.position = groundHitPos;
        }
    }

    public void PlaceObject(GameObject objectPrefab)
    {
        if (groundHitPos != null)
        {
            arObject = Instantiate(objectPrefab, groundHitPos, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("AR plane not found");
        }

    }
}
