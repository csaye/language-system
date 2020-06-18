﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace VideoGame.UI
{
    public class MenuButton : MonoBehaviour
    {
        public void SwitchScene(string scene)
        {
            SceneManager.LoadScene(scene);
        }
        
        public void SwitchLanguage(string language)
        {
            Localization.LocalizationManager.currentLanguage = language;
        }
    }
}
