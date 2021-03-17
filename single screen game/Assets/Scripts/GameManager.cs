using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private UnityEvent<string> addScore;
    private Vector3 startPos;
  private int score;

     private void Start()
        {
            startPos = player.transform.position;
               Time.timeScale = 0;
              score = 0;
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

                  public void AddScore(int scoreAmt)
                     {
                         score += scoreAmt;
                         UpdateUI();
                     }

                     private void UpdateUI()
                         {
                             addScore.Invoke(score.ToString());
                         }
}
