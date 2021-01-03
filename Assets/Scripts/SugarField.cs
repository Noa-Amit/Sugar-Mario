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
    [SerializeField] public double maxSugarAllowed;
    [SerializeField] public double minSugarAllowed;
    private double sugar;
    private SugarBar sugarBar;

    void Start(){
        textField = GetComponent<TextMeshPro>();
        sugar = initSugar;
        textField.text = sugar.ToString();
        sugarBar = GameObject.Find("SugarBar").GetComponent<SugarBar>();
        setBar();
    }

    public void SetNumber(double newNumber) {
        this.sugar = newNumber;
        this.textField.text = ((int)sugar).ToString();
        setBar();
    }

    public void AddToNumber(double newNumber) {
        this.sugar += newNumber;
        this.textField.text = ((int)sugar).ToString();
        setBar();
    }

    public void Init() {
        sugar = initSugar;
        this.textField.text = ((int)sugar).ToString();
        setBar();
    }

    public double GetSugar(){ return sugar;}

    public bool isValid(){//check if sugar too low or high
        if(sugar <= minSugarAllowed || sugar >= maxSugarAllowed){
            return false;
        }
        return true;
    }

    private void setBar(){
        sugarBar.SetHealth((int)sugar);
    }
}
