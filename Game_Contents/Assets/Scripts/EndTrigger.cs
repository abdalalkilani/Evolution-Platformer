
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter2D(Collider2D END){
        gameManager.CompleteLevel();
    }
}
