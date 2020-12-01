using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FieldsChanger : MonoBehaviour
{
    [SerializeField] string enemyTag;
    [SerializeField] SugarField sugarField;
    [SerializeField] LifeField lifeField;

    [Tooltip("How many suager mario lost in walk")]
    [SerializeField] double lostOnWalk;
    [Tooltip("How many suager mario lost in jamp")]
    [SerializeField] double lostOnJump;

   private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == enemyTag) {
            lifeField.SubLife();
            if (lifeField.numLife == 0) { //check if out of life
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
            }
        }
    }

    void Update () {
        if(Input.GetAxis("Horizontal") != 0){
            sugarField.AddToNumber(lostOnWalk);
        }
        if(Input.GetAxis("Vertical") != 0){
            sugarField.AddToNumber(lostOnJump);
        }

        if(sugarField.sugar <= 35 || sugarField.sugar >= 150){ //check if sugar too low or high
            lifeField.SubLife();
            sugarField.Init();
        }
    }
}
