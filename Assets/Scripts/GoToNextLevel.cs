using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoToNextLevel : MonoBehaviour
{
    [SerializeField] string triggingTag;
    private void OnTriggerEnter2D(Collider2D collision) {
        if(triggingTag == collision.tag){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
        }
    }
}
