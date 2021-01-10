using UnityEngine;

public class Collectible : MonoBehaviour{
    [SerializeField] string triggeringTag;
    [SerializeField] double changeSugarOnTrigger;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag) {
        	other.gameObject.GetComponent<FieldsController>().addToSugar(changeSugarOnTrigger);
            Destroy(gameObject);
        }
    }
}
