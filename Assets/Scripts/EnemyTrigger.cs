using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    private bool isTrigg = false;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag) {
            isTrigg = true;
            other.gameObject.GetComponent<FieldsChanger>().subLife();
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == triggeringTag) {
            isTrigg = false;
        }
    }

    public bool getTrigg(){return isTrigg;}

}
