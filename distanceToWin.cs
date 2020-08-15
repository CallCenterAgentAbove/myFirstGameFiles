using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class distanceToWin : MonoBehaviour
{
    public GameObject Player;
    public GameObject finish;
    public TextMeshProUGUI text;
    public float distance;
    void Update()
    {
        //gameObject.GetComponent<TextMeshPro>();
        distance = Vector2.Distance(Player.transform.position, finish.transform.position);
        text.text = "Distance to win " + distance.ToString("F1");
    }
}
