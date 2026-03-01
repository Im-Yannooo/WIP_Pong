using TMPro;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    public void setScore(int val)
    {
        text.text = val.ToString();
    }
}
