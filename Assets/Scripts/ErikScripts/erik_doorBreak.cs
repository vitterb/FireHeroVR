using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class erik_doorBreak : MonoBehaviour
{
  public GameObject door;
  public GameObject brokenDoor;


  private void OnCollisionEnter(Collision other)
  {
      if (other.gameObject.CompareTag("axe"))
      {
          door.SetActive(false);
          brokenDoor.SetActive(true);
      }
  }
}
