using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
   public Text puntuacionText;

   public float  puntuacionValue;

   void Update(){
     
     puntuacionValue +=Time.deltaTime;
     puntuacionText.text = puntuacionValue.ToString("0");
   }
}
