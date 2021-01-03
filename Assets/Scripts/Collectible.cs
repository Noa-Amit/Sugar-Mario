using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour{
    [SerializeField] string triggeringTag;
    [SerializeField] double changeSugarOnTrigger;
    public GameObject floatingText;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag) {
        	other.gameObject.GetComponent<FieldsChanger>().addToSugar(changeSugarOnTrigger);
            Destroy(gameObject);
            if(floatingText) ShowFloatingText();
        }
    }

    private void ShowFloatingText(){
    	var go =Instantiate(floatingText, transform.position, Quaternion.identity, transform);
    	go.GetComponent<TextMeshPro>().text = changeSugarOnTrigger.ToString();
    }
}
