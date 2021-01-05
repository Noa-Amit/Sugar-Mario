using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    [SerializeField] Animator animator;
    GameObject enemy;
    bool isTriggHead;

    void Start (){
        enemy = gameObject.transform.parent.gameObject;
        isTriggHead = false;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && !enemy.GetComponent<EnemyTrigger>().getTriggBody()) {
            isTriggHead = true;
            enemy.GetComponent<EnemyMover>().StopMoving();
            animator.SetBool("is_crash",true);
            StartCoroutine(killEnemy());
        }
    }
    private IEnumerator killEnemy (){
        yield return new WaitForSecondsRealtime(1);
        Destroy(enemy);
    }
    public bool GetTriggHead(){return isTriggHead;}
}
