using UnityEngine;

public class GetInsulin : MonoBehaviour{
    [SerializeField] string triggeringTag = null;
    [SerializeField] SugarField sugarField = null;
    private double changeSugarOnTrigger = 100;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag) {
            sugarField.SetNumber(changeSugarOnTrigger);
        }
    }
}
