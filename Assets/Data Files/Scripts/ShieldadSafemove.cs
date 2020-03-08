using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldadSafemove : MonoBehaviour
{
    
    public GameObject cal;
    public GameObject shield;

    public void movesafe(){
        Debug.Log("arnav");
        gameObject.tag=("Calculator");
        if(gameObject.CompareTag("Calculator")){
            Debug.Log("arnav 1");
            cal.gameObject.transform.Translate(new Vector3(0,-20,-140)*Time.deltaTime);
        }
    }

    public void moveshield(){
        Debug.Log("arushi");
        gameObject.tag=("Shield");
        if(gameObject.CompareTag("Shield")){
            Debug.Log("arushi 1");
            shield.gameObject.transform.Translate(new Vector3(0,-160,0)*Time.deltaTime);
        }
    }
}
