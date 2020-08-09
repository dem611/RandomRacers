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
        GetComponentInChildren<Text>().text = currentRoll.ToString();
        if(rollTotal > 100)
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

            //yield return new WaitForSeconds(2.0f);
            yield return new WaitForSeconds(1f);
            Roll();
        }
    }

    IEnumerator RollAnim()
    {
        int counterdice = 0;
        while (true)
        {
            DiceSlot.sprite = DiceArray[counterdice % 6];
            counterdice++;
            yield return new WaitForSeconds(.1f);
        }
    }
}
