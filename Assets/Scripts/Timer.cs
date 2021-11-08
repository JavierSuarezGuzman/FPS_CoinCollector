using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour

{

    public float maxTime = 60.0f;

    private float countdown = 0.0f;



    // Start is called before the first frame update
    void Start()
    {
        countdown = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            Coin.coinsCount = 0;
            CoinPink.coinsCountPink = 0;
            Application.LoadLevel (Application.loadedLevel);
        }
    }
}
