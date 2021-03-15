using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespon : MonoBehaviour
{
   [SerializeField] private Collider2D playerCheck;
     [SerializeField] private LayerMask playerLayers;
     [SerializeField] private GameManager manager;





     private void OnCollisionEnter2D(Collision2D other)
     {
         if (other.gameObject.tag == "Player")
         {
             manager.RespawnPlayer();
         }
     }
}
