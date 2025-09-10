using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{
    public ParticleSystem trail;
    public GameObject GameOverScreen;
    public ParticleSystem explosion;
    public GameObject player;
    void Start()
    {
        explosion.Stop();
        trail.Play();
        GameOverScreen.SetActive(false);
    }
    public void GameOver()
    {
        player.SetActive(false);
        Invoke("Reload", 2);
        explosion.Play();
        trail.Stop();
        GameOverScreen.SetActive(true);
    }
    void Reload()
    {
        SceneManager.LoadScene(0);
    }
   
    void FixedUpdate()
    {
        explosion.transform.position = player.transform.position;
    }
}


