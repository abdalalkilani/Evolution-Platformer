using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class niosII : MonoBehaviour
{
    // Start is called before the first frame update
    public string horizontalcontr;
    public string jumpcontr;
    public string buttoncontr;
    public void readTextFile(string file_path){
        StreamReader inp_stm = new StreamReader(file_path);
        string inp_ln = inp_stm.ReadLine();
            // Do Something with the input. 
        string[] tokens = inp_ln.Split(' ');
        horizontalcontr= tokens[0];
        jumpcontr=tokens[1];
        buttoncontr=tokens[3];
        inp_stm.Close();
    }

     
    
}
