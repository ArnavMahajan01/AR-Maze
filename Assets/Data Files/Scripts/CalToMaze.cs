using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CalToMaze : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("MainCamera")){
           transform.Translate(new Vector3(0,0,-2)*Time.deltaTime);
           //gameObject.GetComponent<BoxCollider>().enabled=false;
            //SceneManager.LoadScene("End Scene");
        }
    }
    public void restartfunction(){
        SceneManager.LoadScene("AR Maze");
      // Destroy(gameObject.GetComponent<Collider> ());
        gameObject.tag="Calculator";
        // if(gameObject.tag=="Calculator"){
           //Debug.Log("Hi");
           //GameObject.FindWithTag("Calculator").transform.Translate(0,0,-2);
            //transform.position=new Vector3(0,0,-2f);
            //SceneManager.LoadScene("End Scene");
        //}
        // if(CompareTag("Calculator")){
           //  Debug.Log("Hi");
         //  transform.position=new Vector3(0,0,-2f);
        // }
        //cal.GetComponent<Transform>().position.z=-2;
    }
    // Start is called before the first frame update
    void Start()
    {   
        
      
        //cal.transform.Translate (0f, 0f, -2f);
    }

    // Update is called once per frame
    void Update()
    {
          //transform.Translate(new Vector3(0,0,-2)*Time.deltaTime);
    }
}
