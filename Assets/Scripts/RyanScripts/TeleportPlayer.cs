using UnityEngine;

namespace RyanScripts
{
    public class TeleportPlayer : MonoBehaviour
    {
        public Transform teleportTarget;
        public GameObject player;
        void OnTriggerEnter(Collider other)
        {
            player.transform.position = teleportTarget.transform.position;
        }
    }
}

