using UnityEngine;

//there are 2 types of camera, one which follows the player and one which stays showing the whole room:
//these are room camera and follow player, comment out as appropriate
public class CameraController : MonoBehaviour
{
    //Room camera
    [SerializeField] private float speed;
    private float currentPosX;
    private Vector3 velocity = Vector3.zero;

    //Follow player
    [SerializeField] private Transform player;
    [SerializeField] private Transform player2;
    [SerializeField] private float aheadDistance;
    [SerializeField] private float cameraSpeed;
    private float lookAhead;
    private float playery;

    private void Awake()
    {
        playery = player.position.y;
    }

    private void Update()
    {
        //Room camera
        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, transform.position.y, transform.position.z), ref velocity, speed);

        //Follow player
        if((player.position.x > player2.position.x) && ( player.position.y >= playery - 10)){
            transform.position = new Vector3(player.position.x + lookAhead, player.position.y, transform.position.z);
            lookAhead = Mathf.Lerp(lookAhead, (aheadDistance * player.localScale.x), Time.deltaTime * cameraSpeed);
        }
        else{
            transform.position = new Vector3(player2.position.x + lookAhead, player2.position.y, transform.position.z);
            lookAhead = Mathf.Lerp(lookAhead, (aheadDistance * player2.localScale.x), Time.deltaTime * cameraSpeed);
        }
    }
}