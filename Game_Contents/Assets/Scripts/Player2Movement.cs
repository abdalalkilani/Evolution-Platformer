using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Player2Movement : MonoBehaviour
{
    public Rigidbody2D player1;
    public CharacterController2D controller;
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
       
        niosii.readTextFile("/Users/marcochan/InfoProcCW/playercontroltext2.txt");
        horizontalMove = float.Parse(niosii.horizontalcontr) * runSpeed;
        animator.SetFloat("Speed",Mathf.Abs(horizontalMove));
        
        if(niosii.jumpcontr == "1"){
            jump=true;
        }
        animator.SetBool("Jump",jump);
        
        

    }

    public IEnumerator JumpBool(){
        yield return new WaitForSeconds(1);
    }
    void FixedUpdate (){
        controller.Move(horizontalMove* Time.fixedDeltaTime,false, jump);
        if (jump==true){
            jump=false;
            JumpBool();
        }
        
        if(player1.position.y<-6.1f && player1.position.y>-50.1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
