using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class PlayerCombat : MonoBehaviour
{

    [SerializeFeild] private Collider2D PlayerKillCheck;
    [SerializeFeild] private LayerMask PlayerLayers;


    private void Update()
    {
        if(PlayerKillCheck.IsTouchingLayers((int)PlayerLayers))
        {
            Destroy(gameObject);
        }
    }

   private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag =="Player")
        {
            Destroy(other.gameObject);
        }
    }
}

