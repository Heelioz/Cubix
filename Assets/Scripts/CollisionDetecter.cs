using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class CollisionDetecter : MonoBehaviour
{

  [SerializeField] private GameObject MenuGameOver;
  [SerializeField] private GameObject Cube;
   public Text puntuacionText;

   public float  puntuacionValue;
   public float flag;

   public Text maxpuntuacionText;

   public float maxpuntuacionValue;

   public Text puntuacionAlcanzada;

   private void Start()
   {
    flag=0;
     
     maxpuntuacionValue = PlayerPrefs.GetFloat("MaxPuntuacion");
     maxpuntuacionText.text = maxpuntuacionValue.ToString("0");
   }

   void Update(){
     
    if(flag != 1){
     puntuacionValue +=Time.deltaTime;
     puntuacionText.text = puntuacionValue.ToString("0");

     if(maxpuntuacionValue < puntuacionValue){

        PlayerPrefs.SetFloat("MaxPuntuacion", puntuacionValue);

        maxpuntuacionText.text = puntuacionValue.ToString("0");
     }
    }
   }


   private void OnCollisionEnter2D(Collision2D other)
   {
    if(other.collider.CompareTag("Rock")){

        MenuGameOver.SetActive(true);
         flag=1;
         Debug.Log(flag);
         if(flag == 1){
            puntuacionAlcanzada.text =puntuacionValue.ToString("0");
            puntuacionValue=0;
            puntuacionText.text = puntuacionValue.ToString("0");
           
        }
            Cube.SetActive(false);
        
    }
   }

   }
