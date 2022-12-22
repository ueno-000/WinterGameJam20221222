using UnityEngine;

/// <summary>
/// GameManager(�X�R�A�Ǘ��A��������)
/// </summary>
public class GameManager : MonoBehaviour
{
    [SerializeField] private float _timer = 100f;
    [Tooltip("P1�̃X�R�A")]
    [SerializeField] private int _scoreOne = 0;
    [Tooltip("P2�̃X�R�A")]
    [SerializeField] private int _scoreTwo = 0;

    private Winning _win = default;

    public int ScoreOne { get => _scoreOne; set => _scoreOne = value; }
    public int ScoreTwo { get => _scoreTwo; set => _scoreTwo = value; }
    public Winning Win { get => _win; set => _win = value; }

    private void Update()
    {
        _timer -= Time.deltaTime;

        //�J�ڏ����͕ʂ̃N���X
        if (_timer <= 0f)
        {
            //�������Ԃ�0�ɂȂ����珟�����肵�ďI��
            if (_scoreOne > _scoreTwo)
            {
                //P1�̏���
                _win = Winning.PLAYER_ONE;
            }
            else if (_scoreOne < _scoreTwo)
            {
                //P2�̏���
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
