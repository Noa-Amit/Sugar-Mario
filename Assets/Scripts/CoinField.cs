using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an integer number to the text field.
 */
[RequireComponent(typeof(TextMeshPro))]
public class CoinField : MonoBehaviour {
	private TextMeshPro textField;
	private int coins =0;

    void Start() {
    	textField = GetComponent<TextMeshPro>();
        
    }

    public void AddCoins(int coinsNum) {
        this.coins += coinsNum;
        this.textField.text = coins.ToString();
    }

}
