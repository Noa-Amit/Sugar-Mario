using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an integer number to the text field.
 */
[RequireComponent(typeof(TextMeshPro))]
public class SugarField : MonoBehaviour {
    private TextMeshPro textField;
    [SerializeField] public double initSugar;
    public double sugar;

    void Start(){
        textField = GetComponent<TextMeshPro>();
        sugar = initSugar;
        textField.text = sugar.ToString();
    }

    public void SetNumber(double newNumber) {
        this.sugar = newNumber;
        this.textField.text = ((int)sugar).ToString();
    }

    public void AddToNumber(double newNumber) {
        this.sugar += newNumber;
        this.textField.text = ((int)sugar).ToString();
    }

    public void Init() {
        sugar = initSugar;
        this.textField.text = ((int)sugar).ToString();
    }
}
