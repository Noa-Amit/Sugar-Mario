using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCollectible : MonoBehaviour
{
    [SerializeField] string triggeringTag = null;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag) {
        	other.gameObject.GetComponent<FieldsController>().addLife();
        	Destroy(gameObject);
        }
    }
}
