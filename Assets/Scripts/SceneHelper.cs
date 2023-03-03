using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHelper : MonoBehaviour
{
    public void RestartLevel()
    {                                                                           //Перезапускаем текущий уровень
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadLevel(int buildindex)
    {
        SceneManager.LoadScene(buildindex);                                     //Загружаем текущий уровень
    }

    public void OnApplicationQuit()
    {
        Application.Quit();                                                     //Выход из приложения
    }
}
