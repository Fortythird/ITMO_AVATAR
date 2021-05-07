using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnim : MonoBehaviour
{
    public GameObject Cat, Music, Heart, P1, P2, P3, P4, P5;
    private float Timer = 0f; 

    void Update()
    {
        if (Music.active) Timer += Time.deltaTime; 
        if (Timer > 5.3f && Timer < 8f) if (Cat.transform.position.x > P2.transform.position.x) Cat.transform.position = Vector3.MoveTowards(Cat.transform.position, P2.transform.position, 20f * Time.deltaTime);
        if (Timer > 10f && Timer < 12f) if (Cat.transform.position.x < P1.transform.position.x) Cat.transform.position = Vector3.MoveTowards(Cat.transform.position, P1.transform.position, 20f * Time.deltaTime);
        if (Timer > 14f && Timer < 16f) Cat.transform.position = P3.transform.position;
        if (Timer > 16f && Timer < 20f) if (Cat.transform.position.x > P4.transform.position.x) Cat.transform.position = Vector3.MoveTowards(Cat.transform.position, P4.transform.position, 1f * Time.deltaTime);
        if (Timer > 22f) Heart.SetActive(true);
        if (Timer > 24f && Timer < 29f) if (Cat.transform.position.x > P5.transform.position.x) Cat.transform.position = Vector3.MoveTowards(Cat.transform.position, P5.transform.position, 1f * Time.deltaTime);
        if (Timer > 29f)
        {
            Cat.transform.position = P1.transform.position;
            Heart.SetActive(false);
            Timer = 0f;
        }
    }
}
