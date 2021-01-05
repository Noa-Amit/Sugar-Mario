using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    private bool isTriggBody = false;

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("enter");
        if (other.gameObject.tag == triggeringTag && !transform.GetChild(0).gameObject.GetComponent<DestroyEnemy>().GetTriggHead()) {
            isTriggBody = true;
            other.gameObject.GetComponent<FieldsChanger>().subLife();
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        Debug.Log("exit");
        if (other.gameObject.tag == triggeringTag) {
            isTriggBody = false;
        }
    }

    public bool getTriggBody(){return isTriggBody;}

}
