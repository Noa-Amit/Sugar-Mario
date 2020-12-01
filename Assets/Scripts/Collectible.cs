using UnityEngine;

public class Collectible : MonoBehaviour{
    [SerializeField] string triggeringTag = null;
    [SerializeField] SugarField sugarField = null;
    [SerializeField] double changeSugarOnTrigger;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag) {
            sugarField.AddToNumber(changeSugarOnTrigger);
            Destroy(gameObject);
        }
    }
}
