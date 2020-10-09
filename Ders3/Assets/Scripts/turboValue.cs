using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turboValue : MonoBehaviour
{
    public static int TurboValue = 0;
    Text Turbo;
    void Start()
    {
        Turbo = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TurboValue == 0)
        {
            Turbo.text = "Turbo : Pasif";
            Turbo.color = Color.grey;
        }
        else
        {
            Turbo.text = "Turbo : Aktif";
            Turbo.color = Color.white;
        }
            
    }
}
