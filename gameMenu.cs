using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play(){
         SceneManager.LoadScene("level1", LoadSceneMode.Single);

    }
    public void gotoChallenge(){
        SceneManager.LoadScene("challangeScene", LoadSceneMode.Single);
    }
}
