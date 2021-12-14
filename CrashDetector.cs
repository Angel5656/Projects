using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] AudioClip crashSFX;
    [SerializeField] ParticleSystem CrashEffect;
    [SerializeField] float LoadDelay = 0.5f;
    bool madeCrash = false;
   void OnTriggerEnter2D(Collider2D other)
   {
       
       if(other.tag == "Ground" && !madeCrash )
       {
           madeCrash=true;
           CrashEffect.Play();
           GetComponent<AudioSource>().PlayOneShot(crashSFX);
           FindObjectOfType<PlayerController>().DisableControls();
           
           Invoke("ReloadScene", LoadDelay);
       }
   }
   void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}