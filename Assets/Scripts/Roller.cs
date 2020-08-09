using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Roller : MonoBehaviour
{
    int currentRoll;
    public int rollTotal = 0;
    public int whichRoller;
    float screenPos;

    public Sprite Dice1;
    public Sprite Dice2;
    public Sprite Dice3;
    public Sprite Dice4;
    public Sprite Dice5;
    public Sprite Dice6;

    Sprite[] DiceArray;

    public Image DiceSlot;

    bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        DiceArray = new Sprite[] { Dice1, Dice2, Dice3, Dice4, Dice5, Dice6 };
        StartCoroutine(Rolling()); 
    }



    void Roll()
    {
        currentRoll = Mathf.RoundToInt(Random.RandomRange(1.0f, 6.0f));
        rollTotal += currentRoll;
        GetComponentInChildren<Text>().text = rollTotal.ToString();
        switch (currentRoll)
        {
            case 1:
                StopCoroutine(RollAnim());
                DiceSlot.sprite = DiceArray[0];
                StartCoroutine(WaitTime(3f));
                break;
            case 2:
                StopCoroutine(RollAnim());
                DiceSlot.sprite = DiceArray[1];
                StartCoroutine(WaitTime(3f));
                break;
            case 3:
                StopCoroutine(RollAnim());
                DiceSlot.sprite = DiceArray[2];
                StartCoroutine(WaitTime(3f));
                break;
            case 4:
                StopCoroutine(RollAnim());
                DiceSlot.sprite = DiceArray[3];
                StartCoroutine(WaitTime(3f));
                break;
            case 5:
                StopCoroutine(RollAnim());
                DiceSlot.sprite = DiceArray[4];
                StartCoroutine(WaitTime(3f));
                break;
            case 6:
                StopCoroutine(RollAnim());
                DiceSlot.sprite = DiceArray[5];
                StartCoroutine(WaitTime(3f));
                break;

        }
        if(rollTotal >=
            100)
        {
            //SAVE NUMBER FOR TIEBREAKER
            rollTotal = 100;
            GetComponent<AudioSource>().Play();
            StopAllCoroutines();
        }

        float v = rollTotal * (Screen.width-100)/100;

        gameObject.transform.position = new Vector3(v, gameObject.transform.position.y, gameObject.transform.position.z);
        
    }

    IEnumerator Rolling()
    {

        StartCoroutine(RollAnim());
        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            isPaused = true;
            Roll();
            yield return new WaitForSeconds(1.5f);
            isPaused = false;
        }
    }

    IEnumerator RollAnim()
    {
        int counterdice = 0;
        while (true)
        {
            while (isPaused)
            {
                yield return null;
            }
            DiceSlot.sprite = DiceArray[counterdice % 6];
            counterdice++;
            yield return new WaitForSeconds(.1f);
        }
    }

    IEnumerator WaitTime(float sec)
    {
        yield return new WaitForSeconds(sec);
    }
}
