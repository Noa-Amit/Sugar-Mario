using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FieldsChanger : MonoBehaviour
{
    [SerializeField] string enemyTag;
    [SerializeField] SugarField sugarField;
    [SerializeField] LifeField lifeField;
    [SerializeField] int timeToPower;
    private bool isSuperPow = false;

    //flashing
    private bool flashActive;
    public float flashLength;
    private float flashCounter;
    private SpriteRenderer playerSprite;

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
            flashPlayer();
            lifeField.SubLife();
            validLife();
        }
    }
    public void addLife(){
        lifeField.AddLife();
    }
    private void validSugar(){
        if(!sugarField.isValid()){ 
            subLife();
            sugarField.Init();
        }
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
        yield return new WaitForSecondsRealtime(timeToPower);
        isSuperPow = false;
        transform.GetChild(0).gameObject.SetActive(false);
    }
//**** flashing *****
    private void flashPlayer(){
        flashActive = true;
        flashCounter = flashLength;
    }

    void Start(){
        playerSprite = GetComponent<SpriteRenderer>();
    }

    void Update(){
        if(flashActive){
            if(flashCounter > flashLength * .66f){
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            } else if(flashCounter > flashLength * .33f){
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
            } else if(flashCounter > 0f) {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            } else {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
                flashActive = false;
            }
            flashCounter -= Time.deltaTime;
        }
    }
}
