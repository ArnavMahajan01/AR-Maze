using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchingScene : MonoBehaviour
{
     public void restartfunction(){
        SceneManager.LoadScene("Switching Maze to Planets");
    }
}
