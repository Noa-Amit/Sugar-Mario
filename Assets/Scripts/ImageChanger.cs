using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageChanger : MonoBehaviour
{
    public Sprite stay, jump, walk;

    public void WalkR(){
    	gameObject.GetComponent<SpriteRenderer>().sprite = walk;
    }
    public void WalkL(){
    	gameObject.GetComponent<SpriteRenderer>().flipX = true;
    	// gameObject.transform.Rotate(0, 180, 0, Space.Self);
    	gameObject.GetComponent<SpriteRenderer>().sprite = walk;
    }
    public void Stay(){
    	gameObject.transform.Rotate(0, 0, 0, Space.Self);
    	gameObject.GetComponent<SpriteRenderer>().sprite = stay;
    }
    public void Jump(){
    	gameObject.GetComponent<SpriteRenderer>().sprite = jump;
    }
}
