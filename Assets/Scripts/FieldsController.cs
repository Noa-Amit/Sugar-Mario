using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FieldsController : MonoBehaviour
{
    [SerializeField] SugarField sugarField = null;
    [SerializeField] LifeField lifeField = null;
    [SerializeField] CoinField coinField = null;
    [SerializeField] int timeToPower = 0;
    private bool isSuperPow = false;

//**** sugar changer ****
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
    private void validSugar(){
        if(!sugarField.isValid()){ 
            subLife();
            sugarField.Init();
        }
    }
//**** life changer ****
    public void subLife(){
        if(!isSuperPow){
            flashing(this.gameObject);
            lifeField.SubLife();
            validLife();
        }
    }
    public void addLife(){
        lifeField.AddLife();
    }
    private void validLife(){
        if (lifeField.GetLife() == 0) { //check if out of life
                SceneManager.LoadScene("GameOver");  
        }
    }
//**** coins changer ****
    public void addCoins(int coins){
        coinField.AddCoins(coins);
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
    private void flashing(GameObject obj){
        GetComponent<Flashing>().flashObject(obj);
    }
}
