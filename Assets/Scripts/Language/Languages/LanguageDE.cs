using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageDE : MonoBehaviour
{
    public static string GetField(string fieldID)
    {
        switch (fieldID)
        {
            case "item_apple": return "apfel";
            case "item_banana": return "banane";
            case "item_orange": return "orange";

            case "menu_videogame": return "Videospiel";
            case "menu_start": return "Start";
            case "menu_quit": return "Verlassen";

            default:
                Debug.Log("Error: field ID could not be found");
                return null;
        }
    }
}
