using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToNextLevel : MonoBehaviour {

    [SerializeField] string triggingTag = null;

    private void OnTriggerEnter2D(Collider2D other) {
        if(triggingTag == other.gameObject.tag){
            StartCoroutine(waitForSecond());
        }
    }
    private IEnumerator waitForSecond(){
        yield return new WaitForSecondsRealtime(0.5f);
        NextLevel();
    }

    public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
    }

    public void ToLevel(string name){
    	SceneManager.LoadScene(name);  
    }
}
