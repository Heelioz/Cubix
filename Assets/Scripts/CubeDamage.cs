using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDamage : MonoBehaviour
{
    

    private int vida = 1;

    public void TomarDaño(int CantidadDaño){

        vida -= CantidadDaño;

        if(vida<=0){
            Destroy(gameObject);
        }
    }
}
