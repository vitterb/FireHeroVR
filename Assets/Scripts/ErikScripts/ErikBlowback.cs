using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErikBlowback : MonoBehaviour
{
   private float blowback = 10f;

   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Player"))
      {
         Rigidbody rigidbody = other.GetComponent<Rigidbody>();
         if (rigidbody != null)
         {
            Vector3 direction = (other.transform.position - transform.position).normalized;
            rigidbody.AddForce(direction * blowback, ForceMode.Impulse);
         }
      }
   }
}
