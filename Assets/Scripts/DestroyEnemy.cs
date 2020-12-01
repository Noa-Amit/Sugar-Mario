using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    GameObject enemy;

    void Start (){
        enemy = gameObject.transform.parent.gameObject;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && !enemy.GetComponent<EnemyTrigger>().isTrigg) {
            Destroy(enemy);
        }
    }
}
