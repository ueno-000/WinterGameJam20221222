using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Tooltip("�V�[�����UI(0:P1Score, 1:P2Score)")]
    [SerializeField] private Text[] _texts = new Text[2];
    [Tooltip("P1, P2��Image")]
    [SerializeField] private Image[] _images = new Image[2];
    [Tooltip("�����A�s�k��Sprite")]
    [SerializeField] private Sprite[] _winning = new Sprite[2];

    private void Start()
    {
        //P1����
        if (GameManager.Win == Winning.PlayerOne)
        {
            _images[0].GetComponent<Image>().sprite = _winning[0];
            _images[1].GetComponent<Image>().sprite = _winning[1];
        }
        //P2����
        else if (GameManager.Win == Winning.PlayerTwo)
        {
            _images[0].GetComponent<Image>().sprite = _winning[1];
            _images[1].GetComponent<Image>().sprite = _winning[0];
        }
        //���������̏ꍇ��Player��Image���o��

        //�X�R�A�\��
        _texts[0].text = GameManager.ScoreOne.ToString("F0");
        _texts[1].text = GameManager.ScoreTwo.ToString("F0");
    }
}
