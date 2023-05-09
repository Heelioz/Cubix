using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
 //Creacion de variables para detectar que boton se esta pulsando ambas por defecto seran falsas
  bool Left = false;
  bool Right = false;

  public Rigidbody2D rd;
  public float MovementSpeed;

  public void clickLeft(){
     
     Left = true;

  }

  publiv void releaseLeft(){

      Left=false;

  }

  public void clickRight(){

    Right=true;

  }

  publiv void releaseRight(){

    Right=false;

  }
 
}
