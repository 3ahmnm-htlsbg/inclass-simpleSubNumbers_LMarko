using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public Text Result;
    public InputField InputField_varA;
    public InputField InputField_varB;
    public Button SubNumbersButton;
    public Button ResetButton;


    public void SetResult()
    {
        Result.text = SubNumbers().ToString();
        InputField_varA.interactable = false;
        InputField_varB.interactable = false;
        SubNumbersButton.interactable = false;
        ResetButton.interactable = true;

    }

    public void Reset()
    {
        InputField_varA.text = "0";
        InputField_varB.text = "0";
        Result.text = "0";
        InputField_varA.interactable = true;
        InputField_varB.interactable = true;
        SubNumbersButton.interactable = true;
        ResetButton.interactable = false;
    }

    private int SubNumbers()
    {
        int tempResult = int.Parse(InputField_varA.text) - int.Parse(InputField_varB.text);
        return tempResult;
    }
}
