using TMPro;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Score_Zone_Script : MonoBehaviour
{
    [SerializeField] private TextMeshPro text;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            
        }
    }
}
