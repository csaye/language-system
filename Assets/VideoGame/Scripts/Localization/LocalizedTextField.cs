using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VideoGame.Localization
{
    public class LocalizedTextField : MonoBehaviour
    {
        [Header("References")]
        public LocalizedReference localizedReference;

        void Start()
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = LocalizationManager.getField(localizedReference);
        }
    }
}
