using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundTrigger : MonoBehaviour {
	[SerializeField] string triggeringTag = null;
	[SerializeField] AudioClip soundToPlay = null;
	[SerializeField] float volume = 0;
	[SerializeField] GameObject soundTrigger;
	private bool alreadyPlayed = false;
    // void Start() {
    //     audio = GetComponent<AudioSource>();
    // }
    void OnTriggerEnter2D(Collider2D other) {
    	if (other.gameObject.tag == triggeringTag) {
	    	if(!alreadyPlayed) {
	    		// audio.PlayOneShot(soundToPlay,Volume);
	    		GameObject audio = Instantiate(soundTrigger, transform.position, Quaternion.identity) as GameObject;
	    		audio.GetComponent<AudioSource>().PlayOneShot(soundToPlay,volume);
	    		alreadyPlayed = true;
	    	}
    	}
    }
}
