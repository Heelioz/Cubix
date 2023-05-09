
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
 //Creacion de variables para detectar que boton se esta pulsando ambas por defecto seran falsas
  bool Left = false;
  bool Right = false;

  public Rigidbody2D rb;
  public float MovementSpeed;

  public void clickLeft(){
     
     Left = true;

  }

  public void releaseLeft(){

      Left=false;

  }

  public void clickRight(){

    Right=true;

  }

  public void releaseRight(){

    Right=false;

  }

  public void FixedUpdate(){

    if (Left)
     {
      rb.AddForce(new Vector2(-MovementSpeed,0 )* Time.deltaTime);
     }

     if (Right)
     {
      rb.AddForce(new Vector2(MovementSpeed,0 )* Time.deltaTime);
     }
     
  }
 
}
