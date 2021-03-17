using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 startPos;

     private void Start()
        {
            startPos = player.transform.position;
               Time.timeScale = 0;

            }

             public void RespawnPlayer()
                {
                    player.transform.position = startPos;
                }

               public void PauseGame()
               {
               Time.timeScale = 0;
               }

                public void UnPauseGame()
                {
                 Time.timeScale = 1;
                 }
}
