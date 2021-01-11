using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour {
   [SerializeField] GameObject music = null;
   [SerializeField] Sprite imgOn, imgOff;
   private bool isOn;
   
   void Start(){ isOn = true;}

   public void OnOff(){
   		if(isOn) isOn = false;
   		else isOn = true;

   		music.SetActive(isOn);
   		GetComponent<Image>().sprite = isOn ? imgOn : imgOff;
   }
}
