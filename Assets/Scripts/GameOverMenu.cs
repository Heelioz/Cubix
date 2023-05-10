using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
     //Este script funciona para hacer la transicion de la escena principal 

   public void Play(){

      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );

   }

}
