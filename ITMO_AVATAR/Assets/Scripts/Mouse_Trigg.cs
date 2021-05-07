using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Trigg : MonoBehaviour
{
    public GameObject Mouse;

    void OnMouseUpAsButton()
    {
        Mouse.SetActive(true);
    }

}
