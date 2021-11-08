using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CalculateScript : MonoBehaviour
{
    public InputField inputWeight;
    public InputField inputHeight;
    public Text txtResult;
    float bmi;
    public void CalculateOnClicked()
    {
        bmi = ((float.Parse)(inputWeight.text) / ((float.Parse)(inputHeight.text) * 2 * 0.01f));
        txtResult.text = "" + bmi.ToString("0.00");
        if (bmi < 16)
            txtResult.text = "Your bmi: " + bmi.ToString("0.00") + " - SevereThinness";
        else if( bmi >=16 && bmi <17)
            txtResult.text = "Your bmi: " + bmi.ToString("0.00") + " - Moderate Thinness";
        else if(bmi >= 17 && bmi < 18.5)
            txtResult.text = "Your bmi: " + bmi.ToString("0.00") + " - Mild Thinness";
        else if(bmi >= 18.5 && bmi < 25)
            txtResult.text = "Your bmi: " + bmi.ToString("0.00") + " - Normal";
        else if(bmi >= 25 && bmi < 30)
            txtResult.text = "Your bmi: " + bmi.ToString("0.00") + " - Overweight";
        else if(bmi >=30 && bmi < 35)
            txtResult.text = "Your bmi: " + bmi.ToString("0.00") + " - Obese Class 1";
        else if(bmi >= 35 && bmi < 40)
            txtResult.text = "Your bmi: " + bmi.ToString("0.00") + " - Obese Class 2";
        else 
            txtResult.text = "Your bmi: " + bmi.ToString("0.00") + " - Obese Class 3";
    }

    public void ClearOnClicked()
    {
        inputWeight.text = "";
        inputHeight.text = "";
        txtResult.text = "Result";
    }
}
