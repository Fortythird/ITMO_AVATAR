﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_1 : MonoBehaviour
{

    public GameObject Hands, Heart, Opening, Start_Text, Test_Cat, Mouse, CPM, CP1, CP2, CP3, CP4, CP5, CP6, CP7, CP8, CP9, OUT1, OUT2, OUT3;
    public Text timer;
    private GameObject[] CP;
    private Vector3 Out;
    private int k = 0, n = 8;
    private float speed = 2f, time = 3f, Cat_Sadness = 10f, min;
    private bool start = false, define = false;
    Animator cat_anim; // for cat animation
    SpriteRenderer cat_sprite_renderer;



    void Start()
    {
        CP = new GameObject[9];
        CP[0] = CP1;
        CP[1] = CP2;
        CP[2] = CP3;
        CP[3] = CP4;
        CP[4] = CP5;
        CP[5] = CP6;
        CP[6] = CP7;
        CP[7] = CP8;
        CP[8] = CP9;
        cat_anim = Test_Cat.GetComponent<Animator> ();
        cat_sprite_renderer = Test_Cat.GetComponent<SpriteRenderer>();
        
    }

    void Update()
    {
        if (Opening.active == false)
        {
            if (time >= -1f) time -= Time.deltaTime;
            if (time > 2f && timer.text != "3") timer.text = 3.ToString();
            else if (time > 1f && time < 2f && timer.text != "2") timer.text = 2.ToString();
            else if (time > 0f && time < 1f && timer.text != "1") timer.text = 1.ToString();
            else if (time < 0f && time > -1f && timer.text != "Start!") timer.text = "Start".ToString();
            else if (time <= -1f)
            {
                Start_Text.SetActive(false);
                start = !start;
            }

            if (Cat_Sadness > 0f && start && (n > k || !Mouse.active))
            {
                for (int i = 0; i < Hands.transform.childCount - 1; i++)
                {
                    Transform child = Hands.transform.GetChild(i);
                    if ((Test_Cat.transform.position - child.transform.position).magnitude <= 10f) Cat_Sadness -= Time.deltaTime;
                }
                switch (k)
                {
                    case 0:
                        {
                            cat_anim.SetBool("IsMovingForward?", true);
                            cat_anim.SetBool("IsMovingDown?", false);
                            Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, CP[k].transform.position, speed * Time.deltaTime);
                            if (Test_Cat.transform.position.x >= CP[k].transform.position.x) k++;

                            break;
                        }
                    case 1:
                        {
                            cat_anim.SetBool("IsMovingForward?", false);
                            cat_anim.SetBool("IsMovingDown?", true);
                            cat_sprite_renderer.flipX = false;
                            Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, CP[k].transform.position, speed * Time.deltaTime);
                            if (Test_Cat.transform.position.y <= CP[k].transform.position.y) k++;
                            break;
                        }
                    case 2:
                        {
                            cat_anim.SetBool("IsMovingForward?", true);
                            cat_anim.SetBool("IsMovingDown?", false);
                            Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, CP[k].transform.position, speed * Time.deltaTime);
                            if (Test_Cat.transform.position.x <= CP[k].transform.position.x) k++;
                            break;
                        }
                    case 3:
                        {
                            cat_anim.SetBool("IsMovingForward?", false);
                            cat_anim.SetBool("IsMovingDown?", true);
                            Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, CP[k].transform.position, speed * Time.deltaTime);
                            if (Test_Cat.transform.position.y <= CP[k].transform.position.y) k++;
                            break;
                        }
                    case 4:
                        {
                            cat_anim.SetBool("IsMovingForward?", true);
                            cat_anim.SetBool("IsMovingDown?", false);
                            Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, CP[k].transform.position, speed * Time.deltaTime);
                            if (Test_Cat.transform.position.x <= CP[k].transform.position.x) k++;
                            break;
                        }
                    case 5:
                        {
                            cat_anim.SetBool("IsMovingForward?", false);
                            cat_anim.SetBool("IsMovingDown?", true);
                            Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, CP[k].transform.position, speed * Time.deltaTime);
                            if (Test_Cat.transform.position.y <= CP[k].transform.position.y) k++;
                            break;
                        }
                    case 6:
                        {
                            cat_anim.SetBool("IsMovingForward?", true);
                            cat_anim.SetBool("IsMovingDown?", false);
                            Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, CP[k].transform.position, speed * Time.deltaTime);
                            if (Test_Cat.transform.position.x <= CP[k].transform.position.x) k++;
                            break;
                        }
                    case 7:
                        {
                            cat_anim.SetBool("IsMovingForward?", false);
                            cat_anim.SetBool("IsMovingDown?", true);
                            cat_sprite_renderer.flipX = true;
                            Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, CP[k].transform.position, speed * Time.deltaTime);
                            if (Test_Cat.transform.position.y <= CP[k].transform.position.y) k++;
                            break;
                        }
                    case 8:
                        {
                            cat_anim.SetBool("IsMovingForward?", true);
                            cat_anim.SetBool("IsMovingDown?", false);
                            Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, CP[k].transform.position, speed * Time.deltaTime);
                            if (Test_Cat.transform.position.x >= CP[k].transform.position.x) k++;
                            break;
                        }
                    default:
                        {
                            Test_Cat.transform.position = CPM.transform.position;
                            k = 0;
                            break;
                        }
                }
            }
            if (start && Mouse.active)
                switch (n)
                {
                    case 0:
                        {
                            Mouse.transform.position = Vector3.MoveTowards(Mouse.transform.position, CPM.transform.position, speed * Time.deltaTime);
                            if (Mouse.transform.position.x <= CPM.transform.position.x) n--;
                            if (n == k) Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, Mouse.transform.position, speed * Time.deltaTime);
                            break;
                        }
                    case 1:
                        {
                            Mouse.transform.position = Vector3.MoveTowards(Mouse.transform.position, CP[n - 1].transform.position, speed * Time.deltaTime);
                            if (Mouse.transform.position.y >= CP[n - 1].transform.position.y) n--;
                            if (n == k) Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, Mouse.transform.position, speed * Time.deltaTime);
                            if (n < k)
                            {
                                Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, CP[k - 1].transform.position, speed * Time.deltaTime);
                                if (Test_Cat.transform.position.y >= CP[k - 1].transform.position.y) k--;
                            }
                            break;
                        }
                    case 2:
                        {
                            Mouse.transform.position = Vector3.MoveTowards(Mouse.transform.position, CP[n - 1].transform.position, speed * Time.deltaTime);
                            if (Mouse.transform.position.x >= CP[n - 1].transform.position.x) n--;
                            if (n == k) Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, Mouse.transform.position, speed * Time.deltaTime);
                            if (n < k)
                            {
                                Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, CP[k - 1].transform.position, speed * Time.deltaTime);
                                if (Test_Cat.transform.position.x >= CP[k - 1].transform.position.x) k--;
                            }
                            break;
                        }
                    case 3:
                        {
                            Mouse.transform.position = Vector3.MoveTowards(Mouse.transform.position, CP[n - 1].transform.position, speed * Time.deltaTime);
                            if (Mouse.transform.position.y >= CP[n - 1].transform.position.y) n--;
                            if (n == k) Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, Mouse.transform.position, speed * Time.deltaTime);
                            if (n < k)
                            {
                                Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, CP[k - 1].transform.position, speed * Time.deltaTime);
                                if (Test_Cat.transform.position.y >= CP[k - 1].transform.position.y) k--;
                            }
                            break;
                        }
                    case 4:
                        {
                            Mouse.transform.position = Vector3.MoveTowards(Mouse.transform.position, CP[n - 1].transform.position, speed * Time.deltaTime);
                            if (Mouse.transform.position.x >= CP[n - 1].transform.position.x) n--;
                            if (n == k) Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, Mouse.transform.position, speed * Time.deltaTime);
                            if (n < k)
                            {
                                Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, CP[k - 1].transform.position, speed * Time.deltaTime);
                                if (Test_Cat.transform.position.x >= CP[k - 1].transform.position.x) k--;
                            }
                            break;
                        }
                    case 5:
                        {
                            Mouse.transform.position = Vector3.MoveTowards(Mouse.transform.position, CP[n - 1].transform.position, speed * Time.deltaTime);
                            if (Mouse.transform.position.y >= CP[n - 1].transform.position.y) n--;
                            if (n == k) Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, Mouse.transform.position, speed * Time.deltaTime);
                            if (n < k)
                            {
                                Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, CP[k - 1].transform.position, speed * Time.deltaTime);
                                if (Test_Cat.transform.position.y >= CP[k - 1].transform.position.y) k--;
                            }
                            break;
                        }
                    case 6:
                        {
                            Mouse.transform.position = Vector3.MoveTowards(Mouse.transform.position, CP[n - 1].transform.position, speed * Time.deltaTime);
                            if (Mouse.transform.position.x >= CP[n - 1].transform.position.x) n--;
                            if (n == k) Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, Mouse.transform.position, speed * Time.deltaTime);
                            if (n < k)
                            {
                                Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, CP[k - 1].transform.position, speed * Time.deltaTime);
                                if (Test_Cat.transform.position.x >= CP[k - 1].transform.position.x) k--;
                            }
                            break;
                        }
                    case 7:
                        {
                            Mouse.transform.position = Vector3.MoveTowards(Mouse.transform.position, CP[n - 1].transform.position, speed * Time.deltaTime);
                            if (Mouse.transform.position.y >= CP[n - 1].transform.position.y) n--;
                            if (n == k) Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, Mouse.transform.position, speed * Time.deltaTime);
                            if (n < k)
                            {
                                Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, CP[k - 1].transform.position, speed * Time.deltaTime);
                                if (Test_Cat.transform.position.y >= CP[k - 1].transform.position.y) k--;
                            }
                            break;
                        }
                    case 8:
                        {
                            Mouse.transform.position = Vector3.MoveTowards(Mouse.transform.position, CP[n - 1].transform.position, speed * Time.deltaTime);
                            if (Mouse.transform.position.x <= CP[n - 1].transform.position.x) n--;
                            if (n == k) Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, Mouse.transform.position, speed * Time.deltaTime);
                            if (n < k)
                            {
                                Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, CP[k - 1].transform.position, speed * Time.deltaTime);
                                if (Test_Cat.transform.position.x <= CP[k - 1].transform.position.x) k--;
                            }
                            break;
                        }
                    default:
                        {
                            Mouse.SetActive(false);
                            n = 8;
                            Mouse.transform.position = CP[8].transform.position;
                            break;
                        }
                }
            if (Cat_Sadness <= 0f)
            {
                if (!define)
                {
                    min = (Test_Cat.transform.position - OUT1.transform.position).magnitude;
                    Out = OUT1.transform.position;
                    if ((Test_Cat.transform.position - OUT2.transform.position).magnitude < min)
                    {
                        min = (Test_Cat.transform.position - OUT2.transform.position).magnitude;
                        Out = OUT2.transform.position;
                    }
                    if ((Test_Cat.transform.position - OUT3.transform.position).magnitude < min)
                    {
                        min = (Test_Cat.transform.position - OUT3.transform.position).magnitude;
                        Out = OUT3.transform.position;
                    }
                    define = true;
                    Heart.SetActive(true);
                }
                Test_Cat.transform.position = Vector3.MoveTowards(Test_Cat.transform.position, Out, speed * 1.5f * Time.deltaTime);
                if ((Test_Cat.transform.position - Out).magnitude <= 1f)
                {
                    Test_Cat.transform.position = CPM.transform.position;
                    Heart.SetActive(false);
                    define = false;
                    Cat_Sadness = 20f;
                    k = 0;
                }
            }
        }
    }
}
