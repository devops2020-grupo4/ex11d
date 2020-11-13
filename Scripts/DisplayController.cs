using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayController : MonoBehaviour
{
    private Text displayText;
    public Calculator calculator;
    private string lastEntered;

    void Start()
    {
        displayText = GameObject.Find("DisplayText").GetComponent<Text>();
        setStartingZero();

    }
    public void setStartingZero()
    {
        displayText.text = "0";

    }
    public void ClearDisplay()
    {
        displayText.text = "";

    }

    public void UpdateDisplayText(string newText)
    {
        if (displayText.text != "0")
        {
            displayText.text = validateOperation(newText);
        }
        else
        {
            if (newText!="*"&& newText!="/" && newText != "+") {
                ClearDisplay();
                displayText.text = validateOperation(newText);
            }
        }
    }

    string validateOperation(string newText)
    {
        string displayedText = displayText.text;
        if (!int.TryParse(newText, out int n))
        {
            if (lastEntered == "+" || lastEntered == "-" || lastEntered == "/" || lastEntered == "*")
            {
                if (displayedText.Length > 0)
                {
                    displayedText = displayedText.Remove(displayedText.Length - 1, 1);
                }
                displayedText += newText;
            }
            else
            {
                displayedText += newText;
            }
        }
        else
        {
            displayedText += newText;
        }
        lastEntered = newText;
        return displayedText;
    }
}