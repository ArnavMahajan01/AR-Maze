using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaloarSystemtoeachPlanet : MonoBehaviour
{
    //public bool didFunction = false ;
       public void tosun(){
        SceneManager.LoadScene("Sun Info");
        }

        public void tovenus(){
        SceneManager.LoadScene("Venus Info");
        }

        public void tomercury(){
        SceneManager.LoadScene("Mercury Info");
        }
        public void toearthandmoon(){
        SceneManager.LoadScene("Earth an moon info");
        }

        public void tomars(){
        SceneManager.LoadScene("Mars info");
        }

        public void tojupiter(){
        SceneManager.LoadScene("Jupiter info");
        }

        public void tosaturn(){
        SceneManager.LoadScene("Saturn info");
        }

        public void touranus(){
        SceneManager.LoadScene("Uranus info");
        }

        public void toneptune(){
        SceneManager.LoadScene("Neptune info");
        }

        public void tocontinue(){
        SceneManager.LoadScene("Question Solar System");
         
         //didFunction = true ;
        }

        public void trans(){
            Debug.Log("Coming in");
            gameObject.transform.Translate(0,0,-2f);
        }
        
}
