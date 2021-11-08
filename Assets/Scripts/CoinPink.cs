using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPink : MonoBehaviour {

    public static int coinsCountPink = 0; // un contador

    // Start is called before the first frame update
    void Start () { // Se hace solo al inicio
        Debug.Log ("Moneda rosada creada satisfactoriamente"); //message:"Inicio del objeto clase Coin,";
        CoinPink.coinsCountPink++; //suma cuando se crea un 'método' (sic) 

    }

    // Update is called once per frame
    void Update () {        // hacer que haga una vez, (que se destruye)
    }

    void OnTriggerEnter(Collider collider) { //Nombre para asegurarnos que es el Player sea el que interactúa
        Debug.Log("He tocado la moneda rosada!"); // OnDestroy? -- Error v
        if (collider.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    void OnDestroy() {
        CoinPink.coinsCountPink--;

            if (CoinPink.coinsCountPink <= 0) {
            Debug.Log("El juego a terminado NIVEL DIFÍCIL, haz ganado!");

            GameObject timer = GameObject.Find("GameTimer");
            Destroy(timer);

            GameObject[] fireworks = GameObject.FindGameObjectsWithTag("Firework2");
            //gameobject el objeto en el juego, no es caseSensitive //WithTag("nombre tag")
            foreach (GameObject Firework2 in fireworks)
            { //Primero va el tag, después el GameObject
                Firework2.GetComponent<ParticleSystem>().Play(); //tag
            }
        }
    }

}
