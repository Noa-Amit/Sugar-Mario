using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FieldsChanger : MonoBehaviour
{
    [SerializeField] string enemyTag;
    [SerializeField] SugarField sugarField;
    [SerializeField] LifeField lifeField;
    private bool isSuperPow = false;

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
    public void addLife(){
        lifeField.AddLife();
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
        transform.GetChild(0).gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(10);
        isSuperPow = false;
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
