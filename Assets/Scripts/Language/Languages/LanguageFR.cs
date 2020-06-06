using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageFR
{
    public static string GetField(string fieldID)
    {
        switch (fieldID)
        {
            case "item_apple": return "pomme";
            case "item_banana": return "banane";

            default:
                Debug.Log("Error: field ID could not be found");
                return null;
        }
    }
}
