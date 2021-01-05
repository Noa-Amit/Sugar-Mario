// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using TMPro;

// public class TextPopup : MonoBehaviour
// {
//     private TextMeshPro textMesh;
//      // public Transform pfTextPopup;

//     public static TextPopup Create(Vector3 position, int value){
//     	Transform textPopupTransform = Instantiate(GameAssets.i.pfTextPopup, position, Quaternion.identity);
//         TextPopup t = textPopupTransform.GetComponent<TextPopup>();
//         t.SetUp(value);
//         return t;
//     }

//     private void Awake(){
//     	textMesh = transform.GetComponent<TextMeshPro>();
//     }

//     public void SetUp(int value){
//     	textMesh.SetText(value.ToString());
//     }

// }
