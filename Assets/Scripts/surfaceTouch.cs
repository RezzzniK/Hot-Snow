using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class surfaceTouch : MonoBehaviour
{   [SerializeField] ParticleSystem touchGround;
     private void OnTriggerEnter2D(Collider2D other)
    {
            // Debug.Log("TOUCH");
        if (other.gameObject.tag == "Ground")
        {
            //SceneManager.LoadScene(0);// Debug.Log("Crushed");
            touchGround.Play();
          

        }
    }
 

    private void OnTriggerExit2D(Collider2D other)
    {
         if (other.gameObject.tag == "Ground")
        {
            //SceneManager.LoadScene(0);// Debug.Log("Crushed");
            touchGround.Stop();
          

        }
    }
}
