using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextField : MonoBehaviour
{
    public string fieldID;

    void Awake()
    {
        // GetComponent<TextMeshProGUI>().text = LanguageManager.current.fieldID;
        GetComponent<TMPro.TextMeshProUGUI>().text = "hi";
    }
}
