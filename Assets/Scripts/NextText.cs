using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextText : MonoBehaviour {
    private GameObject bubble;
    static int textNum;
    GameObject currentText;
    GameObject currentBold;

    void Start() {
        textNum = 1;
        bubble = gameObject.transform.root.gameObject;
        string name = "Text" + (textNum);
        string boldName = "Bold" + (textNum);
        currentText = bubble.transform.Find(name).gameObject;
        currentBold = bubble.transform.Find(boldName).gameObject;
        textNum++;
    }
    public void Next() {
        Debug.Log(currentText.name);
        Debug.Log(currentBold.name);
        currentText.SetActive(false);
        currentBold.SetActive(false);
        string name = "Text" + (textNum);
        string boldName = "Bold" + (textNum);
        Debug.Log(name);
        Debug.Log(boldName);
        if (textNum < 9)
        {
            currentText = bubble.transform.Find(name).gameObject;
            currentBold = bubble.transform.Find(boldName).gameObject;
            currentText.SetActive(true);
            currentBold.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        textNum++;

    }
}