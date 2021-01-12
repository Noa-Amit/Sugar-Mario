using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TextMesh))]
public class SetCoins : MonoBehaviour
{
	 private TextMesh textField;
    // Start is called before the first frame update
    void Start() {
        int coins = PlayerPrefs.GetInt("coins");
        textField = GetComponent<TextMesh>();
        textField.text = coins.ToString();
    }
}
