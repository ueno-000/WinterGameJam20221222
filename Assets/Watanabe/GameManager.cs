using Common;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// GameManager(スコア管理、制限時間)
/// </summary>
public class GameManager : MonoBehaviour
{
    [Tooltip("制限時間")]
    [SerializeField] private float _timer = Define.GAME_TIME;
    [SerializeField] private int _scoreOne = 0;
    [SerializeField] private int _scoreTwo = 0;

    private GameManager _instance = default;
    private SceneManager _scene = default;
    /// <summary> 勝利判定 </summary>
    private Winning _win = default;

    public int ScoreOne { get => _scoreOne; set => _scoreOne = value; }
    public int ScoreTwo { get => _scoreTwo; set => _scoreTwo = value; }
    public Winning Win { get => _win; set => _win = value; }

    private void Start()
    {
        _instance = this;
        SceneChangeScript.Changing = false;
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == Define.SCENENAME_TITLE)
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
        _scene = GameObject.Find("").GetComponent<SceneManager>();
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
