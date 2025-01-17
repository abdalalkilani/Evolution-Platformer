using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if((other.CompareTag("Player")) | (other.CompareTag("Player2")))
        {
            SceneManager.LoadScene("Level2");
        }
    }

}
