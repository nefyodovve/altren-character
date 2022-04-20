using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VariableRenderer : MonoBehaviour
{
    public IntVariable Variable;

    Text textObject;
    void Awake()
    {
        textObject = GetComponent<Text>();
    }

    void Update()
    {
        textObject.text = Variable.Value.ToString();
    }
}
