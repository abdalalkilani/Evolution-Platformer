using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Player2movement : MonoBehaviour
{
    public Rigidbody2D player2;
    public CharacterController2D controller2;

    [SerializeField] private LayerMask groundLayer;
    private BoxCollider2D boxCollider;
    public Animator animator;
    public niosII niosii;
    public float runSpeed=40f;
    float horizontalMove = 0f;
    //float move=0f;
    bool jump = false;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
       
        // niosii.readTextFile("/Users/marcochan/InfoProcCW/playercontroltext2.txt");
        // horizontalMove = float.Parse(niosii.horizontalcontr) * runSpeed;
        horizontalMove = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed",Mathf.Abs(horizontalMove));
        
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            jump=true;   
            
        }
        animator.SetBool("Jump",jump);
       
    }

    // public IEnumerator JumpBool(){
    //     yield return new WaitForSeconds(1);
    // }\
    void FixedUpdate (){
        controller2.Move(horizontalMove* Time.fixedDeltaTime,false, jump);
        jump=false;
            //StartCoroutine(JumpBool());
        
        
        if(player2.position.y<-6.1f && player2.position.y>-50.1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
