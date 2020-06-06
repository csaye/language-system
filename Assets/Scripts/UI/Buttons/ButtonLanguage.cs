using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLanguage : MonoBehaviour
{
    public void SwitchLanguage(string language)
    {
        LanguageManager.currentLanguage = language;
    }
}
