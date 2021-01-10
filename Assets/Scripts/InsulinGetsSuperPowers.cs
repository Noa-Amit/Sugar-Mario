using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsulinGetsSuperPowers : MonoBehaviour{
	[SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag) {
        	other.gameObject.GetComponent<FieldsController>().getSuperPowers();
            Destroy(gameObject);
        }
    }
}
