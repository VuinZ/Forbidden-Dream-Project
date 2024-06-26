using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeCollider : MonoBehaviour
{
    public GameObject codeEnterUI, canvasButton;
    private bool onRange = false;

    void Update(){
        if(onRange && codeEnterUI != null){
            if(Input.GetKeyDown(KeyCode.F)){
                codeEnterUI.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            onRange = true;
            canvasButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Player")){
            onRange = false;
            canvasButton.SetActive(false);
        }
    }
}