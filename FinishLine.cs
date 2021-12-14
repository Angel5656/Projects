using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem FinishEffect;
    [SerializeField] float LoadDelay = 1f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            FinishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", LoadDelay);
        }
        
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
