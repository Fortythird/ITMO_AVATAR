using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_Button : MonoBehaviour {

    public GameObject Panel, Start_Menu, Level1, Opening, Cat;


    void OnMouseUp()
    {
        Opening.SetActive(true);
    }

    void Update()
    {
        if (Cat.transform.localScale.x > 340f)
        {
            Start_Menu.SetActive(false);
            Level1.SetActive(true);
        }
    }
}
