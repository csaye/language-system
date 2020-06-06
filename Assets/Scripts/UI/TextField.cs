using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextField : MonoBehaviour
{
    public string fieldID;

    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = LanguageManager.GetField(fieldID);
    }
}
