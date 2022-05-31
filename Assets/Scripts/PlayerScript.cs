using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private static int currentLevel = 1;
    private int health = 100;
    public Text healthText;
    public Slider healthSlider;
   // public float healthCounter;
    public Text scoreText;
    private static int scoreCounter = 0;
    public float speed = 5;
    public Camera myCamera;
    private AudioSource s;
    public AudioClip collectSound;

    public void Start()
    {
        s = myCamera.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            this.transform.position += Camera.main.transform.forward * speed * Time.deltaTime;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="pickup")
            {
            s.PlayOneShot(collectSound);
            other.gameObject.SetActive(false);
            scoreCounter++;
            scoreText.text = "Score: " + scoreCounter;

            if (scoreCounter == 20)
                {
                    currentLevel++;
                    SceneManager.LoadScene("Level"+currentLevel);

                }

            }

           if (scoreCounter == 40)
            {
            scoreText.text = "We have a WINNER";
            }

            if (other.tag == "Avoid")
            {
            other.gameObject.SetActive(false);
            health -= 20;
            healthText.text = "Health "+health+"%";
            healthSlider.value = health/100f;
            }

            if (health == 0 )
            {
             scoreText.text = "YOU LOSE!";
            }

            
    }



}
