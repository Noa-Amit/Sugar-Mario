using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {
   [SerializeField] GameObject music;
   bool isOn;
   
   void Start(){ isOn = true;}

   void OnOff(){

   		if(isOn) isOn = false;
   		else isOn = true;

   		music.SetActive(isOn);
   }
}
