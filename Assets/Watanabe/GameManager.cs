using Common;
using UnityEngine;

/// <summary>
/// GameManager(�X�R�A�Ǘ��A��������)
/// </summary>
public class GameManager : MonoBehaviour
{
    [Tooltip("��������")]
    [SerializeField] private float _timer = Define.GAME_TIME;
    [SerializeField] private int _scoreOne = 0;
    [SerializeField] private int _scoreTwo = 0;

    /// <summary> �������� </summary>
    private Winning _win = default;

    public int ScoreOne { get => _scoreOne; set => _scoreOne = value; }
    public int ScoreTwo { get => _scoreTwo; set => _scoreTwo = value; }
    public Winning Win { get => _win; set => _win = value; }

    private void Update()
    {
        _timer -= Time.deltaTime;

        //�������Ԃ�0�ɂȂ����珟�����肵�ďI��
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

/// <summary>
/// �����A��������
/// </summary>
public enum Winning
{
    PlayerOne,
    PlayerTwo,
    Draw
}
