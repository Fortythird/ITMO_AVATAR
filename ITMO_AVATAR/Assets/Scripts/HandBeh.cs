using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandBeh : MonoBehaviour
{

    private Vector3 Drag;
    private bool put = false;
    public GameObject Hand, Par, Timer;

    void OnMouseDown()
    {
        if (!Timer.active && !put) Instantiate(Hand, Par.transform.position, Quaternion.identity, Par.transform);
    }

    void OnMouseDrag()
    {
        if (!Timer.active && !put)
        {
            Drag = new Vector3(Input.mousePosition.x - 200f, Input.mousePosition.y - 400f, -2f);
            gameObject.transform.localPosition = Drag;
        }
    }

    void OnMouseUpAsButton()
    {
        if (gameObject.transform.localPosition.y >= 1330.0f || gameObject.transform.localPosition.y <= 272.0f) Destroy(gameObject);
        else put = true;
    }

    void Update()
    {
       

    }
}
