using Common;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// GameManager(スコア管理、制限時間)
/// </summary>
public class GameManager : MonoBehaviour
{
    [Tooltip("制限時間")]
    [SerializeField] private static float _timer = Define.GAME_TIME;
    [SerializeField] private static int _scoreOne = 0;
    [SerializeField] private static int _scoreTwo = 0;

    private GameManager _instance = default;
    private SceneManager _scene = default;
    /// <summary> 勝利判定 </summary>
    private static Winning _win = default;

    public static float Timer { get => _timer; set => _timer = value; }
    public static int ScoreOne { get => _scoreOne; set => _scoreOne = value; }
    public static int ScoreTwo { get => _scoreTwo; set => _scoreTwo = value; }
    public static Winning Win { get => _win; set => _win = value; }

    private void Start()
    {
        _instance = this;
        SceneChangeScript.Changing = false;
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == Define.SCENENAME_MASTERGAME)
        {
            _timer -= Time.deltaTime;

            //シーン遷移したらSceneManagerを探す
            if (SceneChangeScript.Changing)
            {
                GetSceneManager();
            }

            //制限時間が0になったら勝利判定して終了
            if (_timer <= 0f)
            {
                if (_scoreOne > _scoreTwo)
                {
                    _win = Winning.PlayerOne;
                }
                else if (_scoreOne < _scoreTwo)
                {
                    _win = Winning.PlayerTwo;
                }
                else if (_scoreOne == _scoreTwo)
                {
                    _win = Winning.Draw;
                }
                SceneChangeScript.LoadScene(Define.SCENENAME_RESULT);
            }
        }
    }

    private void GetSceneManager()
    {
        //オブジェクト名は後で記述
        _scene = GameObject.Find("SceneManager").GetComponent<SceneManager>();
        SceneChangeScript.Changing = false;
    }
}

/// <summary>
/// 勝ち、引き分け
/// </summary>
public enum Winning
{
    PlayerOne,
    PlayerTwo,
    Draw
}
