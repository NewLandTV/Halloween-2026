using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class VersionText : MonoBehaviour
{
    private TextMeshProUGUI text;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();

        text.text = $"v{Application.version}";
    }
}
