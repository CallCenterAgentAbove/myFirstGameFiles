using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class coinCounter : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int coins;
    //public Collected1 coins;

    // Update is called once per frame
    void Update()
    {
        text.text = "Coins " + coins.ToString() + "/100";
    }

    //public void CoinPlus()
    //{

    //    coins += 1;

    //}
}
