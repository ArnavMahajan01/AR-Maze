using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldQuestion : MonoBehaviour
{
    
 
    
    //public SaloarSystemtoeachPlanet solar;
    // Start is called before the first frame update

    public void moveshield(){
        gameObject.transform.Translate(0,0,-2);
        Debug.Log("Coming ");
        //if(solar.didFunction){
          //  solar.trans();
      //  }
    }
   
}
