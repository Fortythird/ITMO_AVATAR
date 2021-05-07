using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningCatRemoving : MonoBehaviour
{
    public GameObject Opening, Lv1l, Cat;

    void Update()
    {
        if (Cat.transform.localScale.x <= 5f && Lv1l.active == true) Opening.SetActive(false);
    }
}
