using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class ToggleObject : MonoBehaviour
{
    public GameObject TargetObject;

    bool settingsOpened;

    private void Awake()
    {
        settingsOpened = TargetObject.activeSelf;
    }

    public void Toggle()
    {
        TargetObject.SetActive(!settingsOpened);
        settingsOpened = !settingsOpened;
    }
}
