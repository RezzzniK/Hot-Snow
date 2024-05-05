using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadLevelDelay = 0;
    [SerializeField] ParticleSystem finishEffect;
    
  
   
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Alex")
        {
            // Debug.Log("FINSIH");
            GetComponent<AudioSource>().Play();
            finishEffect.Play();
            Invoke("LoadNextLev", loadLevelDelay);///SceneManager.LoadScene(0);///to see what index of the scene, need to open build settings and from the right will see the index
        }
    }
    void LoadNextLev()
    {
        SceneManager.LoadScene(0);
    }
}
