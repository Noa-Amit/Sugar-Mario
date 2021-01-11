using UnityEngine;

public class InsulinGetsBalance : MonoBehaviour{
    [SerializeField] string triggeringTag = null;
    [SerializeField] double changeSugarOnTrigger = -10;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag) {
            FieldsController fc = other.gameObject.GetComponent<FieldsController>();
            fc.addToSugar(changeSugarOnTrigger);
            Destroy(gameObject);
        }
    }
}
