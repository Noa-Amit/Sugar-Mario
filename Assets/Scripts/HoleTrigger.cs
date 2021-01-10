using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleTrigger : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == triggeringTag) {
        	Vector3 pos = other.gameObject.transform.position;
            other.gameObject.GetComponent<FieldsController>().subLife();
            other.gameObject.transform.position = pos + new Vector3(-2f,4.44f,0);
        }
    }
}
