using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ButtonScript : MonoBehaviour
{

    Text textField;
    int number;

    void Start()
    {
        textField = GameObject.Find("Amount").GetComponent<Text>(); 
    }

   public void changeText()
    {
        number += 10;

        textField.text = "" + number;
    }
}
