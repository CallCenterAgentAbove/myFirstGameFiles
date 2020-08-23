using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class fruitCounter : MonoBehaviour
{
    public TextMeshProUGUI fruitText;
    public int fruits;

    // Update is called once per frame
    void Update()
    {
        fruitText.text = "Fruits " + fruits.ToString() + "/50";
    }
}
