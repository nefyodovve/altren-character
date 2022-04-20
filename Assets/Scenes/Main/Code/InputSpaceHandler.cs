using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class InputSpaceHandler : MonoBehaviour
{
    public GameObject SettingsPopup;

    bool settingsOpened;

    private void Awake()
    {
        settingsOpened = SettingsPopup.activeSelf;
    }

    public void ToggleSettings()
    {
        SettingsPopup.SetActive(!settingsOpened);
        settingsOpened = !settingsOpened;
    }
}
