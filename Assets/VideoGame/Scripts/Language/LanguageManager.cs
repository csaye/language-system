using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageManager
{
    
    public static string currentLanguage = "EN";

    public static string GetField(string fieldID)
    {
        switch (currentLanguage)
        {
            case "DE": return LanguageDE.GetField(fieldID);
            case "EN": return LanguageEN.GetField(fieldID);
            case "ES": return LanguageES.GetField(fieldID);
            case "FR": return LanguageFR.GetField(fieldID);
            case "HI": return LanguageHI.GetField(fieldID);

            default:
                Debug.Log("Error: language could not be found");
                return null;
        }
    }
}
