using Common;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// GameManager(�X�R�A�Ǘ��A��������)
/// </summary>
public class GameManager : MonoBehaviour
{
    [Tooltip("��������")]
    [SerializeField] private static float _timer = Define.GAME_TIME;
    [SerializeField] private static int _scoreOne = 0;
    [SerializeField] private static int _scoreTwo = 0;

    [SerializeField] AudioClip _audioClip;
    [SerializeField] AudioSource _audioSource;

    static AudioClip _staticAudioClip;
    static AudioSource _staticAudioSource;

    private GameManager _instance = default;
    private SceneManager _scene = default;
    /// <summary> �������� </summary>
    private static Winning _win = default;

    public static float Timer { get => _timer; set => _timer = value; }
    public static int ScoreOne
    {
        get => _scoreOne;

        set
        {
            _staticAudioSource.PlayOneShot(_staticAudioClip);
            _scoreOne = value;
        }
    }


    public static int ScoreTwo { get => _scoreTwo; set => _scoreTwo = value; }
    public static Winning Win { get => _win; set => _win = value; }

    private void Awake()
    {
        _staticAudioClip = _audioClip;
        _staticAudioSource = _audioSource;

    }

    private void Start()
    {
        _timer = Define.GAME_TIME;
        _scoreOne = 0;
        _scoreTwo = 0;

        _instance = this;
        SceneChangeScript.Changing = false;
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == Define.SCENENAME_MASTERGAME)
        {
            _timer -= Time.deltaTime;

            //�V�[���J�ڂ�����SceneManager��T��
            if (SceneChangeScript.Changing)
            {
                GetSceneManager();
            }

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

    private void GetSceneManager()
    {
        //�I�u�W�F�N�g���͌�ŋL�q
        _scene = GameObject.Find("SceneManager").GetComponent<SceneManager>();
        SceneChangeScript.Changing = false;
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
