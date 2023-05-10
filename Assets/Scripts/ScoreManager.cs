

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreManager : MonoBehaviour
{

  [SerializeField] private GameObject MenuGameOver;
  [SerializeField] private GameObject Cube;
   public Text puntuacionText;

   public float  puntuacionValue;
   public float flag;

   public Text maxpuntuacionText;

   public float maxpuntuacionValue;
   

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

     if(puntuacionValue >= 12){
        //UnityEditor.EditorApplication.isPlaying=false;
        MenuGameOver.SetActive(true);
        flag=1;
        if(flag == 1){
            puntuacionValue=0;
            puntuacionText.text = puntuacionValue.ToString("0");
        }
        Cube.SetActive(false);
     }

    }
   }
}
