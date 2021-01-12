using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    [SerializeField] string triggeringTag = null;
    private bool isTriggBody = false;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == triggeringTag && !transform.GetChild(0).gameObject.GetComponent<DestroyEnemy>().GetTriggHead()) {
            FieldsController fc = other.gameObject.GetComponent<FieldsController>();
            fc.changePosAfterHurt(new Vector3(-3f,0,0));
            isTriggBody = true;
            fc.subLife();
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == triggeringTag) {
            isTriggBody = false;
        }
    }

    public bool getTriggBody(){return isTriggBody;}

}
