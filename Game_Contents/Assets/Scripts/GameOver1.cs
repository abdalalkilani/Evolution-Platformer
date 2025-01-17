using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
    public niosII niosii1;
    public niosII niosii2;

    string contr1;
    string contr2;

    bool Restart1=false;

    bool Restart2=false;

    bool quit1=false;

    bool quit2=false;

    [SerializeField] private Text connection;



    public void Update()
    { 
        niosii1.readTextFile("/Users/marcochan/InfoProcCW/playercontroltext1.txt");
        contr1 = niosii1.buttoncontr;
        niosii2.readTextFile("/Users/marcochan/InfoProcCW/playercontroltext2.txt");
        contr2 = niosii2.buttoncontr;
        if (contr1=="2"){
            Restart1=true;
        }
        if (contr2=="2"){
            Restart2=true;
        }
        if (Restart1 && Restart2){
            Restart1=false;
            Restart2=false;
            PlayGame();
        }


        if (contr1=="1"){
            quit1=true;
        }
        if (contr2=="1"){
            quit2=true;
        }
        if (quit1 && quit2){
            quit1=false;
            quit2=false;
            QuitGame();
        }

    }
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void QuitGame(){
        Application.Quit();
    }
    
}
