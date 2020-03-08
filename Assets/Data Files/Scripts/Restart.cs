using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    //public GameObject cal;
    public void restartfunction(){
        SceneManager.LoadScene("AR Maze");
       // if(cal.CompareTag("Calculator")){
       //     cal.transform.position=new Vector3(0,0,-2f);
        //}
        //cal.GetComponent<Transform>().position.z=-2;
    }
}
