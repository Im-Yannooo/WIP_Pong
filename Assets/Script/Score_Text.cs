using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score_Text : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    public void setScore(int score)
    {
        text.text = score.ToString();
    }
}
