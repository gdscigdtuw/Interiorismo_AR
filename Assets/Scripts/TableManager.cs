using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableManager : MonoBehaviour
{
    //public GameObject furniture;
    //public Button[] planetextbuttons;
    //// Start is called before the first frame update
    //void Awake()
    //{
    //    foreach (var b in planetextbuttons)
    //    {
    //        //GameObject.furniture = b.transform.Find("Mask/RawImage").GetComponent<RawImage>().texture;
    //        b.onClick.AddListener(() => OnClickButton(furniture));
    //    }
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    //void OnClickButton(GameObject furniture)
    //{
    //    DataHandler.Instance.furniture = furniture;
    //}

    private Button btn;
    public GameObject Furniture;

    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(SelectObject);
    }

    void SelectObject()
    {
        DataHandler.Instance.furniture = Furniture;
    }
}

