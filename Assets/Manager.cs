using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI foodName;
    [SerializeField] Image foodSprite;
    [SerializeField] Toggle cutable;

    [SerializeField] Foods[] foods;

    private int actualFood;

    private void Start()
    {
        updateUi();
    }

    public void next()
    {
        if (actualFood == foods.Length-1)
        {
            
            actualFood = 0;
            updateUi();
        }
        else
        {
            actualFood++;
            updateUi();
        }
       
    }

    public void prev() 
    {
        if (actualFood == 0)
        {
            actualFood = foods.Length-1;
            updateUi();
        }
        else
        {
            actualFood--;
            updateUi();
        }
    }

    public void updateUi()
    {
        if (foods[actualFood].cutable)
        {
            cutable.isOn = true;
        }
        else
        {
            cutable.isOn = false;
        }

        foodName.text = foods[actualFood].foodName;
        foodSprite.sprite = foods[actualFood].foodImage;
    }

}
