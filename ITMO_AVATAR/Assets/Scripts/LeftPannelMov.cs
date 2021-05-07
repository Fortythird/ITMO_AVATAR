using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPannelMov : MonoBehaviour {

    private Vector3 Off, On;
    private bool click = false;
    public GameObject Panel;

    void Start()
    {
        Off = new Vector3(-4.6f, 0, Panel.transform.position.z);
        On = new Vector3(-1.119792f, 0, Panel.transform.position.z);
    }

    void OnMouseUpAsButton()
    {
        click = !click;
    }


    void Update () {

        if (click) Panel.transform.position = Vector2.MoveTowards(Panel.transform.position, On, 20f*Time.deltaTime);
        else Panel.transform.position = Vector2.MoveTowards(Panel.transform.position, Off, 20f * Time.deltaTime);

    }

}
