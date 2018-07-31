using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class percent : MonoBehaviour
{
    public Slider slider;
    public Text txt;

    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
        txt.text = (int)(slider.value * 100) + "%";
    }
}



