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
            case "EN": return LanguageEN.GetField(fieldID);
            case "SP": return LanguageSP.GetField(fieldID);
            case "FR": return LanguageFR.GetField(fieldID);

            default:
                Debug.Log("Error: language could not be found");
                return null;
        }
    }
}
