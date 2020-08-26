using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class fruitCounter : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int fruits;

    // Update is called once per frame
    void Update()
    {
        text.text = "Fruits " + fruits.ToString() + "/50";
    }
}
