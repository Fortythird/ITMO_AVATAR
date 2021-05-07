using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class AchieveControl : MonoBehaviour
{
    private int[] Achs;

    void Start()
    {

        string path = Application.dataPath + "/Achieves/Log.txt";
        Achs = new int[14];
        if (!File.Exists(path))
        {
            for (int i = 0; i < 14; i++)
            {
                Achs[i] = 0;
                File.WriteAllText(path, Achs[i].ToString() + "\n");
            }
        }
    }


    void Update()
    {
        
    }
}
