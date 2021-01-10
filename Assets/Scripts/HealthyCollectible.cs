using UnityEngine;

public class HealthyCollectible : MonoBehaviour{
    [SerializeField] string triggeringTag;
    [SerializeField] int addCoinsOnTrigger;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag) {
        	other.gameObject.GetComponent<FieldsController>().addCoins(addCoinsOnTrigger);
            Destroy(gameObject);
        }
    }
}
