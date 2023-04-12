using System.Collections;
using System.Collections.Generic;
using RichKokuban;
using TMPro;
using UnityEngine;
using Color = UnityEngine.Color;

public class TextViewSample : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    
    void Start()
    {
        var result = Align.Center + 
                     Chalk.Yellow + "Hello" + Chalk.Grey["," + Chalk.Red["World!\n"]] +
                     Chalk.Color(Color.blue, "This is ") + Chalk.Color(Color.green, "RichKokuban.\n") +
                     " Thanks for " +  Chalk.Magenta["installing "] + "it!";
        text.text = result.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
