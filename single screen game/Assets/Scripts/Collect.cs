using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
 [SerializeField] private Collider2D collectCheck;
    [SerializeField] private LayerMask playerLayers;
    [SerializeField] private GameManager manager;
    [SerializeField] private int scoreToGive = 1;

    void Update()
    {
       if (collectCheck.IsTouchingLayers(playerLayers))
       {
         manager.AddScore(scoreToGive);
         Destroy(gameObject);
       }
    }
    private void OnCollisionEnter2D(Collision2D other)
      {
        Destroy(gameObject);
      }
}
