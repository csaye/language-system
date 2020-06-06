using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageEN
{
    public static string GetField(string fieldID)
    {
        switch (fieldID)
        {
            case "item_apple": return "apple";
            case "item_banana": return "banana";

            default:
                Debug.Log("Error: field ID could not be found");
                return null;
        }
    }
}
