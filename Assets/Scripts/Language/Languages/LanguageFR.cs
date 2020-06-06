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
            case "item_orange": return "orange";

            case "menu_videogame": return "Jeu Vidéo";
            case "menu_start": return "Début";
            case "menu_quit": return "Quitter";

            default:
                Debug.Log("Error: field ID could not be found");
                return null;
        }
    }
}
