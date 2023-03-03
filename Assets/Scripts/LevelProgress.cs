using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class LevelProgress : Cart                                                   //Наследуемся от класса мяча
{

    [SerializeField] private StoneSpawner spawner;
    //private int currentLevel = 1;                                                   //назначаем текущий уровень
    //public int CurrentLevel => currentLevel;                                        //Делаем текущий уровень публичным
    //
    //
    //protected override void Awake()                                                 //Загружаем текущий уровень
    //{
    //    base.Awake();
    //
    //    Load();
    //}
#if UNITY_EDITOR
    private void Update()                                                           //Метод, позволяющий перезапустить игру на F1
    {                                                                               //и перезапустить уровень на F2
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
    //protected override void OnCollisionSegment(SegmentType type)                    //Увеличиваем номер текущего уровня при достижении финишного сегмента
    //{                                                                               //и сохраняем номер уровня
    //    if (type == SegmentType.Finish)
    //    {
    //        currentLevel++;
    //        Save();
    //    }
    //}
    //
    //public void Save()                                                              //Сохранение уровня
    //{
    //    PlayerPrefs.SetInt("LevelProgress:CurrentLevel", currentLevel);
    //}
    //
    //private void Load()                                                             //Загрузка уровня
    //{
    //    currentLevel = PlayerPrefs.GetInt("LevelProgress:CurrentLevel", 1);
    //}
#if UNITY_EDITOR
    private void Reset()                                                            //Перезагрузка игры
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        spawner.ChangeColor.Invoke();
    }
#endif

}
