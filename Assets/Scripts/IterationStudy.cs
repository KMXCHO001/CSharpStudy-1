using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class IterationStudy : MonoBehaviour
{
    [SerializeField] TMP_Dropdown interestOption;
    [SerializeField] TMP_InputField balanceInput;
    [SerializeField] TMP_InputField interestRateInput;
    [SerializeField] TMP_InputField yearInput;
    [SerializeField] TMP_Text logtext;
    
    
    
    void Start()
    {
       print(interestOption.value);

    }

    public enum Options
    {
        Simple, Compound, SimpleMonthly, CompoundMonthly
    }

    public void OnCalBtnClkEvent()
    {
        float balance = float.Parse(balanceInput.text);
        float interesteRate = float.Parse(interestRateInput.text);
        int year = int.Parse(yearInput.text);
        float result = 0;
        float newInterest = 0;
        float amount = 0;

        switch (interestOption.value)
        {
            case (int)Options.Simple:
                for (int i = 0; i < year; i++)
                {
                    result = balance +(balance * interesteRate / 100);
                }
                break;

            case (int)Options.Compound:
                for (int i = 0;i < year; i++)
                {
                    result += balance + balance * (interesteRate / 100);
                }
                result += balance + newInterest;
                amount = result;
                break;
                logtext.text += $"{i + 1}년 차/{balance}원/{newInterest}원/{result}원|n";
        }

        

    }

    
    void Update()
    {
        
    }
}
