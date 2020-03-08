using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RandomGenerator : MonoBehaviour
{
    public GameObject textbox;
    public int TheNumber1;
    public int TheNumber2;
    public InputField answer;
    public int submit1,submit2;

    public void ToTheMaze(){
        submit1 = int.Parse(answer.text);
        Debug.Log(submit1);
         if(submit1==(TheNumber1+TheNumber2)){
            SceneManager.LoadScene("After Calculator Scene");
        }

        else{
            textbox.GetComponent<Text>().text="Sorry Wrong Answer!!! Please Try again";
        }
    }
    public void Randomgenerat(){
        TheNumber1=Random.Range(1,20);
        TheNumber2=Random.Range(21,40);
        textbox.GetComponent<Text>().text="What is "+TheNumber1+" + "+TheNumber2+" ?";  
        
        
        
        //submit2=submit1;
    }
    // Start is called before the first frame update
    void Start()
    {
       // submit1 = int.Parse(answer.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
