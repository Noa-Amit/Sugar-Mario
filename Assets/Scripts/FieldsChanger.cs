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

    private bool isSuperPow = false;

    private void Update () {
        if(Input.GetAxis("Horizontal") != 0){
            addToSugar(lostOnWalk);
        }
        if(Input.GetAxis("Jump") != 0){
            addToSugar(lostOnJump);
        }
    }

//**** sugar and life changer ****
    public void addToSugar(double value){
        if(!isSuperPow){
            sugarField.AddToNumber(value);
            validSugar();
        }
    }
    public void setSugar(double value){
        if(!isSuperPow){
            sugarField.SetNumber(value);
            validSugar();
        }
    }
    public void subLife(){
        if(!isSuperPow){
            lifeField.SubLife();
            validLife();
        }
    }
    private void validSugar(){
        if(!sugarField.isValid()){ 
            lifeField.SubLife();
            sugarField.Init();
        }
        validLife();//we did subLife so we nood to check
    }
    private void validLife(){
        if (lifeField.GetLife() == 0) { //check if out of life
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
        }
    }

//**** super power changer ****
    public void getSuperPowers(){
        StartCoroutine(changeSuperPow());
    }
    private IEnumerator changeSuperPow (){
        isSuperPow = true;
        yield return new WaitForSecondsRealtime(10);
        isSuperPow = false;
    }
////////
}
