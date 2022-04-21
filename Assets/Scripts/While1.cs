using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class While1 : MonoBehaviour
{
    public int counter;
    public int counterMax;

    public Text Txt_display;

    // Start is called before the first frame update
    void Start()
    {
        while (counter<counterMax)
        {
            Debug.Log(counter);
            counter++;
        }
        Txt_display.text = "termino el while";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
