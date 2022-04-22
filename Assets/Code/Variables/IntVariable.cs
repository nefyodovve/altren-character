using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu]
public class IntVariable : ScriptableObject
{
    public string DeveloperDescription = "";
    public int Value;
    public bool Unsigned = false;

    public void SetValue(int value)
    {
        if (Unsigned && value < 0)
            Value = 0;
        else
            Value = value;
    }

    public void SetValue(IntVariable value)
    {
        SetValue(value.Value);
    }

    public void SetValueString(string s)
    {
        SetValue(int.Parse(s));
    }

    public void ApplyChange(int amount)
    {
        SetValue(Value + amount);
    }

    public void ApplyChange(IntVariable amount)
    {
        SetValue(Value + amount.Value);
    }
}