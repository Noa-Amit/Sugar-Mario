using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour{
    [SerializeField] float speed;
    [SerializeField] Animator animator;
    [SerializeField] float range;
    private double min_pos;
    private double max_pos;
    private bool isRight;

    void Start(){
    	min_pos = transform.position.x - range;
    	max_pos = transform.position.x + range;
    	isRight = true;
    	animator.SetBool("is_right", true);
    }

    void Update(){
    	float x = transform.position.x;
    	if(isRight){
    		transform.position += new Vector3(speed, 0, 0);
    		if (transform.position.x >= max_pos) {
    			isRight = false;
    			animator.SetBool("is_right", false);
    		}
    	}
    	else {
    		transform.position += new Vector3(-1*speed, 0, 0);
    		if (transform.position.x <= min_pos) {
    			isRight = true;
    			animator.SetBool("is_right", true);
    		}
    	}

    }
}
