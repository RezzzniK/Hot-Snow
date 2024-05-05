using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float restartDelay=0f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    private bool crashed=false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground"&&!crashed)
        {   
            FindAnyObjectByType<PlayerController>().DisableControls();
            //SceneManager.LoadScene(0);// Debug.Log("Crushed");
            //GetComponent<AudioSource>().Play();
         
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            crashEffect.Play();
            Invoke("RestartScene",restartDelay);
            crashed=!crashed;
           

        }
    }
    private void RestartScene()
    {
        SceneManager.LoadScene(0);
    }

}
