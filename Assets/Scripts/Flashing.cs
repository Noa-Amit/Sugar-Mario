using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashing : MonoBehaviour {
	[SerializeField] float flashLength;
    private bool flashActive;
    private float flashCounter;
    private SpriteRenderer playerSprite;

    public void flashObject(GameObject obj){
    	playerSprite = obj.GetComponent<SpriteRenderer>();
        flashActive = true;
        flashCounter = flashLength;
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
