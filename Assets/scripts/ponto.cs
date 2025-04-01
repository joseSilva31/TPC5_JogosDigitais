using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ponto : MonoBehaviour
{
    public int pontos;
    public int vidas;
    TextMeshProUGUI textPontos;
    TextMeshProUGUI textVidas;

    void Start()
    {
        pontos = 0;
        vidas = 3;
        textPontos = GameObject.Find("TextPontos").GetComponent<TextMeshProUGUI>();
        textPontos.text = "Pontos: " + pontos.ToString();
        textVidas = GameObject.Find("TextVidas").GetComponent<TextMeshProUGUI>();
        textVidas.text = "Vidas: " + vidas.ToString();
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "moeda")
        {
            pontos += 1;
            textPontos.text = "Pontos: " + pontos.ToString();
            Debug.Log("Pontos: " + pontos);
            Destroy(coll.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "inimigo")
        {
            vidas -= 1;
            textVidas.text = "Vidas: " + vidas.ToString();
            Debug.Log("Vidas: " + vidas);
            
            if (vidas == 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
