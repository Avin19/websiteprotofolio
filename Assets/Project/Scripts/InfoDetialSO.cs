using UnityEngine;

[CreateAssetMenu(fileName = "Info", menuName = "InfoSO")]
public class InfoDetialSO : ScriptableObject
{
    public string Title;
    [Multiline(40)]
    public string Info;
}
