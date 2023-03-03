using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class LevelProgress : Cart                                                   //����������� �� ������ ����
{

    [SerializeField] private StoneSpawner spawner;
    //private int currentLevel = 1;                                                   //��������� ������� �������
    //public int CurrentLevel => currentLevel;                                        //������ ������� ������� ���������
    //
    //
    //protected override void Awake()                                                 //��������� ������� �������
    //{
    //    base.Awake();
    //
    //    Load();
    //}
#if UNITY_EDITOR
    private void Update()                                                           //�����, ����������� ������������� ���� �� F1
    {                                                                               //� ������������� ������� �� F2
        if (Input.GetKeyDown(KeyCode.F1) == true)
        {
            Reset();
        }
        if (Input.GetKeyDown(KeyCode.F2) == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
#endif
    //
    //
    //protected override void OnCollisionSegment(SegmentType type)                    //����������� ����� �������� ������ ��� ���������� ��������� ��������
    //{                                                                               //� ��������� ����� ������
    //    if (type == SegmentType.Finish)
    //    {
    //        currentLevel++;
    //        Save();
    //    }
    //}
    //
    //public void Save()                                                              //���������� ������
    //{
    //    PlayerPrefs.SetInt("LevelProgress:CurrentLevel", currentLevel);
    //}
    //
    //private void Load()                                                             //�������� ������
    //{
    //    currentLevel = PlayerPrefs.GetInt("LevelProgress:CurrentLevel", 1);
    //}
#if UNITY_EDITOR
    private void Reset()                                                            //������������ ����
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        spawner.ChangeColor.Invoke();
    }
#endif

}
