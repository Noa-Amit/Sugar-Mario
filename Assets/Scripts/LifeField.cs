using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an integer number to the text field.
 */
[RequireComponent(typeof(TextMeshPro))]
public class LifeField : MonoBehaviour {
    private TextMeshPro textField;
    [SerializeField] public int numLife;

    void Start(){
        textField = GetComponent<TextMeshPro>();
        textField.text = numLife.ToString();
    }
    public void AddLife(int newNumber) {
        this.numLife = newNumber;
        this.textField.text = numLife.ToString();
    }

    public void AddLife() {
        this.numLife++;
        this.textField.text = numLife.ToString();
    }

    public void SubLife() {
        this.numLife--;
        this.textField.text = numLife.ToString();
    }

}
