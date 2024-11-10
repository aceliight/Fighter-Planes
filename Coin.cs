using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject coin;
    void Start()
    {
        Destroy(this.gameObject, 5f);
    }
    private void OnTriggerEnter2D(Collider2D whatIHit)
    {
        if (whatIHit.tag == "Player")
        {
            //player collects coin
            GameObject.Find("GameManager").GetComponent<GameManager>().EarnScore(1);
            Destroy(this.gameObject);
        }
    }
}
