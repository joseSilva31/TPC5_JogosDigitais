using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(VoltarAoMenu());
    }

    IEnumerator VoltarAoMenu()
    {
        yield return new WaitForSeconds(2); // Espera 3 segundos
        SceneManager.LoadScene("menu"); // Troca para o menu
    }
}
