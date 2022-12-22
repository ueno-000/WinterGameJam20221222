using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{
    [Tooltip("ÉVÅ[Éìè„ÇÃUI(0:Timer, 1:P1Score, 2:P2Score)")]
    [SerializeField] private Text[] _texts = new Text[3];

    private void Update()
    {
        _texts[0].text = GameManager.Timer.ToString("F0");
        _texts[1].text = GameManager.ScoreOne.ToString("F0");
        _texts[2].text = GameManager.ScoreTwo.ToString("F0");
    }
}
