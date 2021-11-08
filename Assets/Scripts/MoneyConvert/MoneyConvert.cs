using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoneyConvert : MonoBehaviour
{
    public InputField input1;
    public InputField input2;
    public Dropdown dropDown1;
    public Text txtvalue;
    public float value;

    
    public void ButtonConvertOnClick()
    {
        if (input1.text == "" && input2.text =="" || input1.text != "" && input2.text != "")
        {
            input1.text = "Choose 1 to input";
            input2.text = "Choose 1 to input";
        }
        else if (input1.text != "" || input2.text != "")
        {
            switch (dropDown1.options[dropDown1.value].text)
            {
                case "USD":
                    value = 22855f;
                    break;
                case "JPY":
                    value = 205.1f;
                    break;
                case "GBP":
                    value = 31713f;
                    break;
                case "EUR":
                    value = 27118f;
                    break;
                case "KRW":
                    value = 20.43f;
                    break;
            }
            if(input1.text != "" && input2.text == "")
            {
                txtvalue.text = value.ToString();
                input2.text =((float.Parse)(input1.text) * value).ToString("0.00");
            }
            else if(input2.text != "" && input1.text == "")
            {
                if(((float.Parse)(input2.text) < 1000))
                {
                    ButtonClearOnClick();
                    input2.contentType.ToString();
                    input2.text = "Input must > 1000";
                    return;
                }
                txtvalue.text = "1 / " + value;
                input1.text = ((float.Parse)(input2.text) / value).ToString("0.00");
            }
        }
        
    }
    
    public void ButtonClearOnClick()
    {
        input1.text = "";
        input2.text = "";
        txtvalue.text = "VALUE";

    }

}
