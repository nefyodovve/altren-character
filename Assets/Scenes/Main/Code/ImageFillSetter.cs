using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFillSetter : MonoBehaviour
{
    [Tooltip("Value to use as the current ")]
    public IntReference Variable;

    [Tooltip("Min value that Variable to have no fill on Image.")]
    public IntReference Min;

    [Tooltip("Max value that Variable can be to fill Image.")]
    public IntReference Max;

    [Tooltip("Image to set the fill amount on.")]
    public Image Image;

    public Text TextTitle;

    public string Title;

    private void Update()
    {
        TextTitle.text = Title + " " + Variable.Value + "/" + Max.Value;

        Image.fillAmount = Mathf.Clamp01(
            Mathf.InverseLerp(Min.Value, Max.Value, Variable.Value));
    }
}
