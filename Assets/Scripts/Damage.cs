
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

   private int daño = 1;
   private void OnTriggerEnter2D(Collider2D collision)
   {
     if (collision.CompareTag("Cube"))
     {
        collision.GetComponent<CubeDamage>().TomarDaño(daño);
        Destroy(gameObject);
     }
   }
}
