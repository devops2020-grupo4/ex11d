using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonController : MonoBehaviour
{
    public string value;

    private DisplayController displayController;
    void Start()
    {
        displayController = GameObject.Find("DisplayText").GetComponent<DisplayController>();
     
    }

    public void AppendValueToDisplay()
    {
        Debug.Log(displayController);
        displayController.UpdateDisplayText(value);
    }

    public void EvaluateEquation()
    {
        displayController.DisplayAnswer();
    }

    public void Clear()
    {
        displayController.setStartingZero();
    }

}