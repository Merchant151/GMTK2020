using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPandScore : MonoBehaviour
{
    Text hptext, scoretext, gameovertext;
    int hp, score;
    HPController tracking;

    // Start is called before the first frame update
    void Start()
    {
        hptext = GameObject.Find("PlayerHP").GetComponent<Text>();
        hp = GameObject.Find("towerRound_crystals").GetComponent<HPController>().hp;
        tracking = GameObject.Find("towerRound_crystals").GetComponent<HPController>();
        scoretext = GameObject.Find("Score").GetComponent<Text>();
        gameovertext = GameObject.Find("GameOver").GetComponent<Text>();
        //gameovertext.enabled = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        hp = tracking.hp;
        hptext.text = "HP: " + hp;
        scoretext.text = "Score: " + score;

        if (Time.timeScale == 0 && Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene("Updated3D");
            Time.timeScale = 1;
            gameovertext.enabled = false;
        }

        if(hp <= 0)
        {
            gameovertext.enabled = true;
            Time.timeScale = 0;
        }

        score = tracking.score;
    }

    public void AddScore(int add)
    {
        score += add;
    }

    public void DealDamage(int damage)
    {
        tracking.hp -= damage;
    }
}
