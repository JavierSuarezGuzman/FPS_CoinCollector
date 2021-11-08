using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    public static int coinsCount = 0; // un contador

    // Start is called before the first frame update
    void Start () { // Se hace solo al inicio
        Debug.Log ("Moneda dorada creada satisfactoriamente"); //message:"Inicio del objeto clase Coin,";
        Coin.coinsCount++; //suma cuando se crea un 'método' (sic) 

    }

    // Update is called once per frame
    void Update () {        // hacer que haga una vez, (que se destruye)
    }

    void OnTriggerEnter(Collider playerCollider) { //Nombre para asegurarnos que es el Player sea el que interactúa
        Debug.Log("He tocado la moneda dorada!"); // OnDestroy? -- ERROR v
        if (playerCollider.CompareTag("Player"))
        {
            Destroy(gameObject); //Esto es el OnDestroy, pero con otro nombre por algún motivo.
        }
    }

    void OnDestroy() {
            Coin.coinsCount--;

            if (Coin.coinsCount <= 0) {
            Debug.Log("El juego a terminado NIVEL FÁCIL, haz ganado!");
            //Application.LoadLevel(Application.loadedLevel);
            GameObject timer = GameObject.Find("GameTimer");
            Destroy(timer);
            //Application.LoadLevel(Application.loadedLevel);


            GameObject[] fireworks = GameObject.FindGameObjectsWithTag("Firework"); 
            //gameobject el objeto en el juego, no es caseSensitive //WithTag("nombre tag")
            foreach (GameObject Firework in fireworks) { //Primero va el tag, después el GameObject
                Firework.GetComponent<ParticleSystem> ().Play(); //tag
            }
        }
    }

}
