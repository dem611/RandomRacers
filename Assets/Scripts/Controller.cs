using System.Collections;
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

    public GameObject FirstBet;
    public GameObject SecondBet;
    public GameObject ThirdBet;
    public GameObject FourthBet;
    public GameObject FifthBet;
    public GameObject FirstBetTop;
    public GameObject SecondBetTop;
    public GameObject ThirdBetTop;
    public GameObject FourthBetTop;
    public GameObject FifthBetTop;
    GameObject[] BetSprites;
    GameObject[] BetSpritesTop;


    public GameObject FirstBetDR;
    public GameObject SecondBetDR;
    public GameObject ThirdBetDR;
    public GameObject FourthBetDR;
    public GameObject FifthBetDR;
    public GameObject FirstBetTopDR;
    public GameObject SecondBetTopDR;
    public GameObject ThirdBetTopDR;
    public GameObject FourthBetTopDR;
    public GameObject FifthBetTopDR;
    GameObject[] BetSpritesDR;

    public GameObject PlayButton;
    public GameObject PlayButtonDR;

    int betcounter = 0;
    List<string> bets = new List<string>();
    List<string> standings = new List<string>();

    List<int> betsDR = new List<int>();
    List<int> endRolls = new List<int>();

    public Image DR1;
    public Image DR2;
    public Image DR3;
    public Image DR4;
    public Image DR5;
    public Image DR6;

    public GameObject FinalText;
    public Text BetAmount;
    public Dropdown BetDD;
    public Text WinAmount;

    bool dice = false;
    // Update is called once per frame
    void Start()
    {
        BetSprites = new GameObject[] { FirstBet, SecondBet, ThirdBet, FourthBet, FifthBet };
        BetSpritesTop = new GameObject[] { FirstBetTop, SecondBetTop, ThirdBetTop, FourthBetTop, FifthBetTop };

        BetSpritesDR = new GameObject[] { FirstBetDR, SecondBetDR, ThirdBetDR, FourthBetDR, FifthBetDR };
        StartCoroutine(Controllers());
    }

    public void DiceMode()
    {
        dice = true;
    }

    public void StartRace()
    {
        roller1.StartRolling();
        roller2.StartRolling();
        roller3.StartRolling();
        roller4.StartRolling();
        roller5.StartRolling();
    }
    
    IEnumerator Controllers()
    {
        while (true)
        {
            yield return new WaitForSeconds(.5f);

            //Race Over
            if (i >= 5)
            {
                roller1.StopAllCoroutines();
                roller2.StopAllCoroutines();
                roller3.StopAllCoroutines();
                roller4.StopAllCoroutines();
                roller5.StopAllCoroutines();

                

                if (dice)
                {
                    CalculateWinningsDR();
                }
                else {
                    CalculateWinnings();
                }
                break;
            }

            if (dice) //Dice Mode
            {
                if (roller1.rollTotal >= 100 && one)
                {
                    Debug.Log("Roll is " + places[i]);
                    endRolls.Add(roller1.currentRoll);
                    switch (i)
                    {
                        case 0:
                            switch (roller1.currentRoll)
                            {
                                case 1:
                                    First.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    First.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    First.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    First.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    First.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    First.sprite = DR6.sprite;
                                    break;
                            }
                            place1.SetActive(true);
                            FinalText.SetActive(true);
                            break;
                        case 1:
                            switch (roller1.currentRoll)
                            {
                                case 1:
                                    Second.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Second.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Second.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Second.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Second.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Second.sprite = DR6.sprite;
                                    break;
                            }
                            place2.SetActive(true);
                            break;
                        case 2:
                            switch (roller1.currentRoll)
                            {
                                case 1:
                                    Third.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Third.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Third.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Third.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Third.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Third.sprite = DR6.sprite;
                                    break;
                            }
                            place3.SetActive(true);
                            break;
                        case 3:
                            switch (roller1.currentRoll)
                            {
                                case 1:
                                    Fourth.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Fourth.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Fourth.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Fourth.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Fourth.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Fourth.sprite = DR6.sprite;
                                    break;
                            }
                            place4.SetActive(true);
                            break;
                        case 4:
                            switch (roller1.currentRoll)
                            {
                                case 1:
                                    Fifth.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Fifth.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Fifth.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Fifth.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Fifth.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Fifth.sprite = DR6.sprite;
                                    break;
                            }
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
                    endRolls.Add(roller2.currentRoll);
                    switch (i)
                    {
                        case 0:
                            switch (roller2.currentRoll)
                            {
                                case 1:
                                    First.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    First.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    First.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    First.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    First.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    First.sprite = DR6.sprite;
                                    break;
                            }
                            place1.SetActive(true);
                            FinalText.SetActive(true);
                            break;
                        case 1:
                            switch (roller2.currentRoll)
                            {
                                case 1:
                                    Second.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Second.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Second.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Second.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Second.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Second.sprite = DR6.sprite;
                                    break;
                            }
                            place2.SetActive(true);
                            break;
                        case 2:
                            switch (roller2.currentRoll)
                            {
                                case 1:
                                    Third.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Third.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Third.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Third.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Third.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Third.sprite = DR6.sprite;
                                    break;
                            }
                            place3.SetActive(true);
                            break;
                        case 3:
                            switch (roller2.currentRoll)
                            {
                                case 1:
                                    Fourth.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Fourth.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Fourth.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Fourth.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Fourth.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Fourth.sprite = DR6.sprite;
                                    break;
                            }
                            place4.SetActive(true);
                            break;
                        case 4:
                            switch (roller2.currentRoll)
                            {
                                case 1:
                                    Fifth.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Fifth.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Fifth.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Fifth.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Fifth.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Fifth.sprite = DR6.sprite;
                                    break;
                            }
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
                    endRolls.Add(roller3.currentRoll);
                    switch (i)
                    {
                        case 0:
                            switch (roller3.currentRoll)
                            {
                                case 1:
                                    First.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    First.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    First.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    First.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    First.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    First.sprite = DR6.sprite;
                                    break;
                            }
                            place1.SetActive(true);
                            FinalText.SetActive(true);
                            break;
                        case 1:
                            switch (roller3.currentRoll)
                            {
                                case 1:
                                    Second.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Second.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Second.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Second.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Second.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Second.sprite = DR6.sprite;
                                    break;
                            }
                            place2.SetActive(true);
                            break;
                        case 2:
                            switch (roller3.currentRoll)
                            {
                                case 1:
                                    Third.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Third.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Third.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Third.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Third.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Third.sprite = DR6.sprite;
                                    break;
                            }
                            place3.SetActive(true);
                            break;
                        case 3:
                            switch (roller3.currentRoll)
                            {
                                case 1:
                                    Fourth.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Fourth.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Fourth.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Fourth.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Fourth.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Fourth.sprite = DR6.sprite;
                                    break;
                            }
                            place4.SetActive(true);
                            break;
                        case 4:
                            switch (roller3.currentRoll)
                            {
                                case 1:
                                    Fifth.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Fifth.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Fifth.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Fifth.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Fifth.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Fifth.sprite = DR6.sprite;
                                    break;
                            }
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
                    endRolls.Add(roller4.currentRoll);
                    switch (i)
                    {
                        case 0:
                            switch (roller4.currentRoll)
                            {
                                case 1:
                                    First.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    First.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    First.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    First.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    First.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    First.sprite = DR6.sprite;
                                    break;
                            }
                            place1.SetActive(true);
                            FinalText.SetActive(true);
                            break;
                        case 1:
                            switch (roller4.currentRoll)
                            {
                                case 1:
                                    Second.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Second.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Second.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Second.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Second.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Second.sprite = DR6.sprite;
                                    break;
                            }
                            place2.SetActive(true);
                            break;
                        case 2:
                            switch (roller4.currentRoll)
                            {
                                case 1:
                                    Third.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Third.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Third.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Third.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Third.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Third.sprite = DR6.sprite;
                                    break;
                            }
                            place3.SetActive(true);
                            break;
                        case 3:
                            switch (roller4.currentRoll)
                            {
                                case 1:
                                    Fourth.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Fourth.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Fourth.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Fourth.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Fourth.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Fourth.sprite = DR6.sprite;
                                    break;
                            }
                            place4.SetActive(true);
                            break;
                        case 4:
                            switch (roller4.currentRoll)
                            {
                                case 1:
                                    Fifth.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Fifth.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Fifth.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Fifth.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Fifth.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Fifth.sprite = DR6.sprite;
                                    break;
                            }
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
                    endRolls.Add(roller5.currentRoll);
                    switch (i)
                    {
                        case 0:
                            switch (roller5.currentRoll)
                            {
                                case 1:
                                    First.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    First.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    First.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    First.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    First.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    First.sprite = DR6.sprite;
                                    break;
                            }
                            place1.SetActive(true);
                            FinalText.SetActive(true);
                            break;
                        case 1:
                            switch (roller5.currentRoll)
                            {
                                case 1:
                                    Second.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Second.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Second.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Second.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Second.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Second.sprite = DR6.sprite;
                                    break;
                            }
                            place2.SetActive(true);
                            break;
                        case 2:
                            switch (roller5.currentRoll)
                            {
                                case 1:
                                    Third.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Third.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Third.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Third.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Third.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Third.sprite = DR6.sprite;
                                    break;
                            }
                            place3.SetActive(true);
                            break;
                        case 3:
                            switch (roller5.currentRoll)
                            {
                                case 1:
                                    Fourth.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Fourth.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Fourth.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Fourth.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Fourth.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Fourth.sprite = DR6.sprite;
                                    break;
                            }
                            place4.SetActive(true);
                            break;
                        case 4:
                            switch (roller5.currentRoll)
                            {
                                case 1:
                                    Fifth.sprite = DR1.sprite;
                                    break;
                                case 2:
                                    Fifth.sprite = DR2.sprite;
                                    break;
                                case 3:
                                    Fifth.sprite = DR3.sprite;
                                    break;
                                case 4:
                                    Fifth.sprite = DR4.sprite;
                                    break;
                                case 5:
                                    Fifth.sprite = DR5.sprite;
                                    break;
                                case 6:
                                    Fifth.sprite = DR6.sprite;
                                    break;
                            }
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
            else //Fruit Mode
            {
                if (roller1.rollTotal >= 100 && one)
                {
                    Debug.Log("Lemon wins " + places[i]);
                    standings.Add("Lemon");
                    switch (i)
                    {
                        case 0:
                            First.sprite = Lemon.sprite;
                            place1.SetActive(true);
                            FinalText.SetActive(true);
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
                    standings.Add("Carrot");
                    switch (i)
                    {
                        case 0:
                            First.sprite = Carrot.sprite;
                            place1.SetActive(true);
                            FinalText.SetActive(true);
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
                    standings.Add("Cherry");
                    switch (i)
                    {
                        case 0:
                            First.sprite = Cherry.sprite;
                            place1.SetActive(true);
                            FinalText.SetActive(true);
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
                    standings.Add("Grape");
                    switch (i)
                    {
                        case 0:
                            First.sprite = Grape.sprite;
                            place1.SetActive(true);
                            FinalText.SetActive(true);
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
                    standings.Add("Apple");
                    switch (i)
                    {
                        case 0:
                            First.sprite = Apple.sprite;
                            place1.SetActive(true);
                            FinalText.SetActive(true);
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


    public void PlaceBetOn(string fruit)
    {
        bets.Add(fruit);
        switch (fruit)
        {
            case "Lemon":
                BetSprites[betcounter].GetComponent<Image>().sprite = Lemon.sprite;
                BetSpritesTop[betcounter].GetComponent<Image>().sprite = Lemon.sprite;
                break;
            case "Cherry":
                BetSprites[betcounter].GetComponent<Image>().sprite = Cherry.sprite;
                BetSpritesTop[betcounter].GetComponent<Image>().sprite = Cherry.sprite;
                break;
            case "Carrot":
                BetSprites[betcounter].GetComponent<Image>().sprite = Carrot.sprite;
                BetSpritesTop[betcounter].GetComponent<Image>().sprite = Carrot.sprite;
                break;
            case "Grape":
                BetSprites[betcounter].GetComponent<Image>().sprite = Grape.sprite;
                BetSpritesTop[betcounter].GetComponent<Image>().sprite = Grape.sprite;
                break;
            case "Apple":
                BetSprites[betcounter].GetComponent<Image>().sprite = Apple.sprite;
                BetSpritesTop[betcounter].GetComponent<Image>().sprite = Apple.sprite;
                break;
        }
        betcounter++;

        if(betcounter == 5)
        {
            PlayButton.SetActive(true);
        }
    }

    public void PlaceBetOnDR(int roll)
    {
        betsDR.Add(roll);
        switch (roll)
        {
            case 1:
                BetSpritesDR[betcounter].GetComponent<Image>().sprite = DR1.sprite;
                BetSpritesTop[betcounter].GetComponent<Image>().sprite = DR1.sprite;
                break;
            case 2:
                BetSpritesDR[betcounter].GetComponent<Image>().sprite = DR2.sprite;
                BetSpritesTop[betcounter].GetComponent<Image>().sprite = DR2.sprite;
                break;
            case 3:
                BetSpritesDR[betcounter].GetComponent<Image>().sprite = DR3.sprite;
                BetSpritesTop[betcounter].GetComponent<Image>().sprite = DR3.sprite;
                break;
            case 4:
                BetSpritesDR[betcounter].GetComponent<Image>().sprite = DR4.sprite;
                BetSpritesTop[betcounter].GetComponent<Image>().sprite = DR4.sprite;
                break;
            case 5:
                BetSpritesDR[betcounter].GetComponent<Image>().sprite = DR5.sprite;
                BetSpritesTop[betcounter].GetComponent<Image>().sprite = DR5.sprite;
                break;
            case 6:
                BetSpritesDR[betcounter].GetComponent<Image>().sprite = DR6.sprite;
                BetSpritesTop[betcounter].GetComponent<Image>().sprite = DR6.sprite;
                break;
        }
        betcounter++;
        foreach (int ints in betsDR)
        {
            Debug.Log(ints);
        }

        if (betcounter == 5)
        {
            DR1.gameObject.SetActive(false);
            DR2.gameObject.SetActive(false);
            DR3.gameObject.SetActive(false);
            DR4.gameObject.SetActive(false);
            DR5.gameObject.SetActive(false);
            DR6.gameObject.SetActive(false);
            PlayButtonDR.SetActive(true);
        }
    }


    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void ChangeBetAmount()
    {
        switch (BetDD.value)
        {
            case 0:
                BetAmount.text = "$10";
                break;
            case 1:
                BetAmount.text = "$100";
                break;
            case 2:
                BetAmount.text = "$1000";
                break;

        }
    }

    public void CalculateWinnings()
    {
        float bet = 0f;
        switch (BetDD.value)
        {
            case 0:
                bet = 10f;
                break;
            case 1:
                bet = 100f;
                break;
            case 2:
                bet = 1000f;
                break;
        }

        List<int> winnings = new List<int>();
        List<bool> winningsbool = new List<bool>();

        int countwins = 0;
        for (int i = 0; i < 5; i++)
        {
            if (bets[i] == standings[i])
            {
                winnings.Add(5-i);
                winningsbool.Add(true);
                countwins++;
                Debug.Log("You got bet " + i + " correct");
            }
            else
            {
                winnings.Add(1);
                winningsbool.Add(false);
                Debug.Log("You got bet " + i + " incorrrect");
            }
        }

        float win = 0f;
        //Match ANY

        win = countwins * bet * .3f;

        if (winningsbool[4] &&
            winningsbool[3] &&
            winningsbool[2] &&
            winningsbool[1] &&
            winningsbool[0])
        {
            win = win * 50;
        }else 
            if(winningsbool[3] &&
            winningsbool[2] &&
            winningsbool[1] &&
            winningsbool[0])
        {
            win = win * 20;
        }else
            if(winningsbool[2] &&
            winningsbool[1] &&
            winningsbool[0])
        {
            win = win * 10;
        }else
            if(winningsbool[1] &&
            winningsbool[0])
        {
            win = win * 4;
        }else
            if (winningsbool[0])
        {
            win = win * 2;
        }
        else if(countwins == 0)
        {
            win = 0f;
        }



        win = Mathf.RoundToInt(win);
        
        
        WinAmount.text = win.ToString();
        

    }

    public void CalculateWinningsDR()
    {
        float bet = 0f;
        switch (BetDD.value)
        {
            case 0:
                bet = 10f;
                break;
            case 1:
                bet = 100f;
                break;
            case 2:
                bet = 1000f;
                break;
        }

        betsDR.Sort();
        endRolls.Sort();

        foreach (int guess in betsDR)
        {
            if (endRolls.Contains(guess))
            {
                endRolls.Remove(guess);
            }
        }

        int numcorrect = 5 - endRolls.Count;

        int winnings = 0;

        switch (numcorrect)
        {
            case 0:
                break;
            case 1:
                winnings = Mathf.RoundToInt(numcorrect * bet * .6f);
                break;
            case 2:
                winnings = Mathf.RoundToInt(numcorrect * bet * .8f);
                break;
            case 3:
                winnings = Mathf.RoundToInt(numcorrect * bet * 1.3f);
                break;
            case 4:
                winnings = Mathf.RoundToInt(numcorrect * bet * 1.6f);
                break;
            case 5:
                winnings = Mathf.RoundToInt(numcorrect * bet * 2.0f);
                break;
        }

        WinAmount.text = winnings.ToString();
    }
}
