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
    // Start is called before the first frame update
    void Start()
    {
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
        while (true)
        {

            //yield return new WaitForSeconds(2.0f);
            yield return new WaitForSeconds(1f);
            Roll();
        }
    }
}
