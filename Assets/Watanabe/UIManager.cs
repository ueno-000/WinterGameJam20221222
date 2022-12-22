using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Tooltip("シーン上のUI(0:Timer, 1:P1Score, 2:P2Score)")]
    [SerializeField] private Text[] _texts = new Text[3];

    private void Update()
    {
        if (_texts[0] != null)
        {
            //タイマー表示
            _texts[0].text = GameManager.Timer.ToString("F2");
        }
        //スコア表示
        _texts[1].text = GameManager.ScoreOne.ToString("F0");
        _texts[2].text = GameManager.ScoreTwo.ToString("F0");
    }
}
