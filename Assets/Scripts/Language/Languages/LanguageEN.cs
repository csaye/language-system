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
            case "item_orange": return "orange";

            case "menu_videogame": return "Video Game";
            case "menu_start": return "Start";
            case "menu_quit": return "Quit";

            default:
                Debug.Log("Error: field ID could not be found");
                return null;
        }
    }
}
