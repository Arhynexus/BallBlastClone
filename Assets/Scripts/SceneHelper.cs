using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHelper : MonoBehaviour
{
    public void RestartLevel()
    {                                                                           //������������� ������� �������
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadLevel(int buildindex)
    {
        SceneManager.LoadScene(buildindex);                                     //��������� ������� �������
    }

    public void OnApplicationQuit()
    {
        Application.Quit();                                                     //����� �� ����������
    }
}
