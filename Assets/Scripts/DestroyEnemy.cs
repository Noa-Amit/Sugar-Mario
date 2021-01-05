using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    [SerializeField] Animator animator;
    GameObject enemy;
    bool isKilled;

    void Start (){
        enemy = gameObject.transform.parent.gameObject;
        isKilled = false;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && !enemy.GetComponent<EnemyTrigger>().getTrigg() && !isKilled) {
            isKilled = true;
            animator.SetBool("is_crash",true);
            StartCoroutine(killEnemy());
        }
    }
    private IEnumerator killEnemy (){
        yield return new WaitForSecondsRealtime(3);
        Destroy(enemy);
    }
}
