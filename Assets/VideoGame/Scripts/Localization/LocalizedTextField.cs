using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VideoGame.Localization
{
    public class LocalizedTextField : MonoBehaviour
    {
        public string type;
        public int line;

        void Start()
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = LocalizationManager.getField(type, line);
        }
    }
}
