﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public Roller roller1;
    public Roller roller2;
    public Roller roller3;
    public Roller roller4;
    public Roller roller5;
    readonly string[] places = new string[5] { "first", "second", "third", "fourth", "fifth" };
    bool one = true;
    bool two = true;
    bool three = true;
    bool four = true;
    bool five = true;
    int i = 0; 

    public Image Lemon;
    public Image Carrot;
    public Image Cherry;
    public Image Grape;
    public Image Apple;

    public Image First;
    public Image Second;
    public Image Third;
    public Image Fourth;
    public Image Fifth;

    public GameObject place1;
    public GameObject place2;
    public GameObject place3;
    public GameObject place4;
    public GameObject place5;

    public GameObject finishline;
    // Update is called once per frame
    void Start()
    {
        finishline.transform.position = new Vector3((Screen.width - 100), finishline.transform.position.y, finishline.transform.position.z);
        StartCoroutine(Controllers());
    }
    
    IEnumerator Controllers()
    {
        while (true)
        {
            yield return new WaitForSeconds(.5f);

            if (i >= 5)
            {
                roller1.StopAllCoroutines();
                roller2.StopAllCoroutines();
                roller3.StopAllCoroutines();
                roller4.StopAllCoroutines();
                roller5.StopAllCoroutines();
                break;
            }
            if (roller1.rollTotal >= 100 && one)
            {
                Debug.Log("Lemon wins " + places[i]);
                switch (i)
                {
                    case 0:
                        First.sprite = Lemon.sprite;
                        place1.SetActive(true);
                        break;
                    case 1:
                        Second.sprite = Lemon.sprite;
                        place2.SetActive(true);
                        break;
                    case 2:
                        Third.sprite = Lemon.sprite;
                        place3.SetActive(true);
                        break;
                    case 3:
                        Fourth.sprite = Lemon.sprite;
                        place4.SetActive(true);
                        break;
                    case 4:
                        Fifth.sprite = Lemon.sprite;
                        place5.SetActive(true);
                        break;
                }
                roller1.StopAllCoroutines();
                roller1.rollTotal = 100;
                i++;
                one = false;
                continue;
            }
            if (roller2.rollTotal >= 100 && two)
            {
                Debug.Log("Carrot wins " + places[i]);
                switch (i)
                {
                    case 0:
                        First.sprite = Carrot.sprite;
                        place1.SetActive(true);
                        break;
                    case 1:
                        Second.sprite = Carrot.sprite;
                        place2.SetActive(true);
                        break;
                    case 2:
                        Third.sprite = Carrot.sprite;
                        place3.SetActive(true);
                        break;
                    case 3:
                        Fourth.sprite = Carrot.sprite;
                        place4.SetActive(true);
                        break;
                    case 4:
                        Fifth.sprite = Carrot.sprite;
                        place5.SetActive(true);
                        break;
                }
                roller2.StopAllCoroutines();
                roller2.rollTotal = 100;
                i++;
                two = false;
                continue;
            }
            if (roller3.rollTotal >= 100 && three)
            {
                Debug.Log("Cherry wins " + places[i]);
                switch (i)
                {
                    case 0:
                        First.sprite = Cherry.sprite;
                        place1.SetActive(true);
                        break;
                    case 1:
                        Second.sprite = Cherry.sprite;
                        place2.SetActive(true);
                        break;
                    case 2:
                        Third.sprite = Cherry.sprite;
                        place3.SetActive(true);
                        break;
                    case 3:
                        Fourth.sprite = Cherry.sprite;
                        place4.SetActive(true);
                        break;
                    case 4:
                        Fifth.sprite = Cherry.sprite;
                        place5.SetActive(true);
                        break;
                }
                roller3.StopAllCoroutines();
                roller3.rollTotal = 100;
                i++;
                three = false;
                continue;
            }
            if (roller4.rollTotal >= 100 && four)
            {
                Debug.Log("Grape wins " + places[i]);
                switch (i)
                {
                    case 0:
                        First.sprite = Grape.sprite;
                        place1.SetActive(true);
                        break;
                    case 1:
                        Second.sprite = Grape.sprite;
                        place2.SetActive(true);
                        break;
                    case 2:
                        Third.sprite = Grape.sprite;
                        place3.SetActive(true);
                        break;
                    case 3:
                        Fourth.sprite = Grape.sprite;
                        place4.SetActive(true);
                        break;
                    case 4:
                        Fifth.sprite = Grape.sprite;
                        place5.SetActive(true);
                        break;
                }
                roller4.StopAllCoroutines();
                roller4.rollTotal = 100;
                i++;
                four = false;
                continue;
            }
            if (roller5.rollTotal >= 100 && five)
            {
                Debug.Log("Apple wins " + places[i]);
                switch (i)
                {
                    case 0:
                        First.sprite = Apple.sprite;
                        place1.SetActive(true);
                        break;
                    case 1:
                        Second.sprite = Apple.sprite;
                        place2.SetActive(true);
                        break;
                    case 2:
                        Third.sprite = Apple.sprite;
                        place3.SetActive(true);
                        break;
                    case 3:
                        Fourth.sprite = Apple.sprite;
                        place4.SetActive(true);
                        break;
                    case 4:
                        Fifth.sprite = Apple.sprite;
                        place5.SetActive(true);
                        break;
                }
                roller5.StopAllCoroutines();
                roller5.rollTotal = 100;
                i++;
                five = false;
                continue;
            }
        }
    }
}