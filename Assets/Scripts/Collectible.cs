using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour{
    [SerializeField] string triggeringTag = null;
    [SerializeField] public double changeSugarOnTrigger = 0;
    [SerializeField] GameObject floatingText;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag) {
        	other.gameObject.GetComponent<FieldsController>().addToSugar(changeSugarOnTrigger);
            Destroy(gameObject);
            GameObject text = Instantiate(floatingText, transform.position, Quaternion.identity) as GameObject;
            text.transform.GetChild(0).GetComponent<TextMesh>().text = "+"+changeSugarOnTrigger;
        }
    }
}
