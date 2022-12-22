using UnityEngine;

/// <summary>
/// GameManager(スコア管理、制限時間)
/// </summary>
public class GameManager : MonoBehaviour
{
    [SerializeField] private float _timer = 100f;
    [Tooltip("P1のスコア")]
    [SerializeField] private int _scoreOne = 0;
    [Tooltip("P2のスコア")]
    [SerializeField] private int _scoreTwo = 0;

    private Winning _win = default;

    public int ScoreOne { get => _scoreOne; set => _scoreOne = value; }
    public int ScoreTwo { get => _scoreTwo; set => _scoreTwo = value; }
    public Winning Win { get => _win; set => _win = value; }

    private void Update()
    {
        _timer -= Time.deltaTime;

        //遷移処理は別のクラス
        if (_timer <= 0f)
        {
            //制限時間が0になったら勝利判定して終了
            if (_scoreOne > _scoreTwo)
            {
                //P1の勝ち
                _win = Winning.PLAYER_ONE;
            }
            else if (_scoreOne < _scoreTwo)
            {
                //P2の勝ち
                _win = Winning.PLAYER_TWO;
            }
            else if (_scoreOne == _scoreTwo)
            {
                //Draw
                _win = Winning.DRAW;
            }
        }
    }
}

public enum Winning
{
    PLAYER_ONE,
    PLAYER_TWO,
    DRAW
}
