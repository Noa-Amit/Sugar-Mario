using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    public bool isTrigg = false;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag) {
            isTrigg = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == triggeringTag) {
            isTrigg = false;
        }
    }

}
