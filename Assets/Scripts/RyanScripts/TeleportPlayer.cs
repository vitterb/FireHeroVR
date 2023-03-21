using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class TeleportPlayer : MonoBehaviour
    {
        public Transform teleportTarget;
        public GameObject player;
        void OnTriggerEnter(Collider other)
        {
            player.transform.position = teleportTarget.transform.position;
        }
    }

