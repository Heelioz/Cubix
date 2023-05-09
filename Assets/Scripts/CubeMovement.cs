
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
 //Creacion de variables para detectar que boton se esta pulsando ambas por defecto seran falsas
  bool Left = false;
  bool Right = false;
  private Animator Animator;


  public Rigidbody2D rb;
  public float MovementSpeed;

  public void clickLeft(){
     
     Left = true;
     Animator.SetBool("running", true);
    

  }

  public void releaseLeft(){

      Left=false;
      Animator.SetBool("running", false);

  }

  public void clickRight(){

    Right=true;
    Animator.SetBool("running", true);

  }

  public void releaseRight(){

    Right=false;
    Animator.SetBool("running", false);

  }

  public void FixedUpdate(){

     Animator = GetComponent<Animator>();

    if (Left)
     {
      rb.AddForce(new Vector2(-MovementSpeed,0 )* Time.deltaTime);
      transform.localScale = new Vector3(-1.0f,1.0f,1.0f);
      
     }

     if (Right)
     {
      rb.AddForce(new Vector2(MovementSpeed,0 )* Time.deltaTime);
      transform.localScale = new Vector3(1.0f,1.0f,1.0f);
      
     }


     
  }
 
}
