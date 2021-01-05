using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SkipText : MonoBehaviour
{
	public void Skip(){
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
