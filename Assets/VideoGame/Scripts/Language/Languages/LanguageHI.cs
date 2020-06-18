using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageHI : MonoBehaviour
{
    public static string GetField(string fieldID)
    {
        switch (fieldID)
        {
            case "item_apple": return "सेब";
            case "item_banana": return "केला";
            case "item_orange": return "संतरा";

            case "menu_videogame": return "वीडियो गेम";
            case "menu_start": return "शुरू";
            case "menu_quit": return "छोड़ना";

            default:
                Debug.Log("Error: field ID could not be found");
                return null;
        }
    }
}
