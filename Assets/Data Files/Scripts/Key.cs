using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour
{
public float speed;

private void CollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("MainCamera")){
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
            //SceneManager.LoadScene("End Scene");
        
        }
}
        public Collision collision;
     private void OnCollisionEnter(Collision collision){

         
        
        if(collision.gameObject.CompareTag("Treasure")){
            SceneManager.LoadScene("End Scene");
        }
     }
    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    public void Update()
    {
    }
}
