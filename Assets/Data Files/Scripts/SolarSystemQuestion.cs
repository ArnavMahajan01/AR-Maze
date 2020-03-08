using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SolarSystemQuestion : MonoBehaviour
{
    public GameObject textbox;
   // public int TheNumber1;
    //public int TheNumber2;
    public InputField answer;
    public int submit1,submit2;

    public string theanswer;
    public void ToTheMaze(){
        theanswer=answer.text;
        //submit1 = int.Parse(answer.text);
        Debug.Log(answer);
         if((theanswer=="Jupiter"||theanswer=="jupiter")){
            SceneManager.LoadScene("AR Maze");
        }

        else{
            textbox.GetComponent<Text>().text="Sorry Wrong Answer!!! Please Try again";
        }
    }
    public void TheQuestion(){
        //TheNumber1=Random.Range(1,20);
       // TheNumber2=Random.Range(21,40);
        textbox.GetComponent<Text>().text="What is the biggest planet in solar system ?";  
        
        
        
        //submit2=submit1;
    }
}