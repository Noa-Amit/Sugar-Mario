using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToNextLevel : MonoBehaviour {

    [SerializeField] string triggingTag = null;

    private void OnTriggerEnter2D(Collider2D collision) {
        if(triggingTag == collision.tag){
            NextLevel();
        }
    }

    public void NextLevel(){
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
    }
}
