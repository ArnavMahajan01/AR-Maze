using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamController : MonoBehaviour
{   
    public float speed;
    void Start()
    {
        
    }

    
    void Update()
    {
        float movecam=Input.GetAxis("Vertical")*speed*Time.deltaTime;
        transform.Translate(0,0,movecam);

        float rotatecam=0;

        if(Input.GetKey(KeyCode.LeftArrow)){
            rotatecam=rotatecam-1;

        }
        
        if(Input.GetKey(KeyCode.RightArrow)){
            rotatecam=rotatecam+1;
            
        }

        transform.Rotate(0,rotatecam,0);

    }

   // public GameObject cal;
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Treasure")){
            SceneManager.LoadScene("End Scene");
        }

        else if(collision.gameObject.CompareTag("Shield")){
            SceneManager.LoadScene("Shield Problem");
        }

         else if(collision.gameObject.CompareTag("Calculator")){
            collision.gameObject.transform.Translate(0,0,-2f);
            Debug.Log("hi ii");
            SceneManager.LoadScene("Calculator Problem");
        }
    }
    
}
