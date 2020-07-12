using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPController : MonoBehaviour
{
    public int hp, score;
    Text gameovertext;

    // Start is called before the first frame update
    void Start()
    {
        hp = 10;
        gameovertext = GameObject.Find("GameOver").GetComponent<Text>();
        gameovertext.enabled = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int add)
    {
        score += add;
    }

    /*private void OnCollisionStay(Collision collision)
    {
        Destroy(collision.gameObject);
    }*/
}
