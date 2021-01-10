using UnityEngine;

public class InsulinGetsBalance : MonoBehaviour{
    [SerializeField] string triggeringTag;
    private double changeSugarOnTrigger = 100;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag) {
            other.gameObject.GetComponent<FieldsController>().setSugar(changeSugarOnTrigger);
            Destroy(gameObject);
        }
    }
}
