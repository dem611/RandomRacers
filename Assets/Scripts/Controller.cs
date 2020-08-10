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

    public GameObject PlayButton;

    int betcounter = 0;
    List<string> bets = new List<string>();
    List<string> standings = new List<string>();

    public GameObject FinalText;
    public Text BetAmount;
    public Dropdown BetDD;
    public Text WinAmount;

    // Update is called once per frame
    void Start()
    {
        BetSprites = new GameObject[] { FirstBet, SecondBet, ThirdBet, FourthBet, FifthBet };
        BetSpritesTop = new GameObject[] { FirstBetTop, SecondBetTop, ThirdBetTop, FourthBetTop, FifthBetTop };
        StartCoroutine(Controllers());
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

                CalculateWinnings();
                break;
            }
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
}
