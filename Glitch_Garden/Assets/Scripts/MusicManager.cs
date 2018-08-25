using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

    [SerializeField] AudioClip[] backgorundMusic;

    AudioSource thisLevelAudio;
   
    int currentScene;
   

    // Use this for initialization
    void Start () {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        
        
        thisLevelAudio = GetComponent<AudioSource>();
        playThisLevelAudio();
        
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    private void playThisLevelAudio()
    {
        var clip = backgorundMusic[currentScene];

        thisLevelAudio.PlayOneShot(clip);
    }
    

}
