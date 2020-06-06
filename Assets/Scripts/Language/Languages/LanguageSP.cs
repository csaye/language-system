using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageSP
{
    public static string GetField(string fieldID)
    {
        switch (fieldID)
        {
            case "item_apple": return "manzana";
            case "item_banana": return "plátano";

            default:
                Debug.Log("Error: field ID could not be found");
                return null;
        }
    }
}
