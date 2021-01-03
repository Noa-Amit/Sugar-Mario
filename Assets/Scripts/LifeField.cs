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
    [SerializeField] public int InitLife;
    private int life;

    void Start(){
        life = InitLife;
        textField = GetComponent<TextMeshPro>();
        textField.text = life.ToString();
    }
    public void AddLife(int newNumber) {
        this.life = newNumber;
        this.textField.text = life.ToString();
    }

    public void AddLife() {
        this.life++;
        this.textField.text = life.ToString();
    }

    public void SubLife() {
        this.life--;
        this.textField.text = life.ToString();
    }

    public int GetLife(){return this.life;}

}
