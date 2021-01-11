using UnityEngine;

public class HealthyCollectible : MonoBehaviour{
    [SerializeField] string triggeringTag = null;
    [SerializeField] int addCoinsOnTrigger = 0;
    [SerializeField] GameObject floatingCoin = null;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag) {
        	other.gameObject.GetComponent<FieldsController>().addCoins(addCoinsOnTrigger);
            Destroy(gameObject);
            GameObject coin = Instantiate(floatingCoin, transform.position, Quaternion.identity) as GameObject;
        }
    }
}
