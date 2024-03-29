﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace VideoGame.Localization
{
    public class LocalizationManager : MonoBehaviour
    {
        public static string currentLanguage = "EN";

        public static string getField(LocalizedReference localizedReference)
        {
            string path = "Assets/VideoGame/Localization/" + currentLanguage + "/" + localizedReference.type + ".txt";

            try
            {
                StreamReader reader = new StreamReader(path);

                for (int i = 0; i < localizedReference.line - 1; i++)
                {
                    reader.ReadLine();
                }

                string result = reader.ReadLine();
                reader.Close();
                return result;
            }
            catch
            {
                Debug.LogError("Could not read field at: " + path);
                return null;
            }
        }
    }
}
