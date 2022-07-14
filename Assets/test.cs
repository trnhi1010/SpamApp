using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    [SerializeField] Slider _slider;
    [SerializeField] private Button button;
    [SerializeField] private TextMeshProUGUI textSound;
 private TMP_Dropdown dropdown;

   public DataTest dataTest;
   public test2 test2;

  

    public void Start()
    {
        _slider.value = dataTest.sound;
        _slider.onValueChanged.AddListener(delegate { OnValueChange(); });
    }

    public void OnValueChange()
    {
        dataTest.sound = _slider.value;
        textSound.text = _slider.value.ToString();
      
    }
}
