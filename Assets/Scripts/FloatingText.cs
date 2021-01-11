using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class FloatingText : MonoBehaviour{
	[SerializeField] float destroyTime = 100f;
	[SerializeField] float speed = 1;

	void Start() {
		TextMeshPro textField = GetComponent<TextMeshPro>();
		double val = transform.parent.gameObject.GetComponent<Collectible>().changeSugarOnTrigger;
		textField.text = "+" + val.ToString();
	}

    // Start is called before the first frame update
    public void floating() {
    	Debug.Log("********in**********");
    	gameObject.SetActive(true);
    	while(destroyTime > 0){
    		gameObject.transform.position += new Vector3(0, speed, 0);
    		destroyTime -= 0.1f;
    	}
    	gameObject.SetActive(false);
    }

   
}
