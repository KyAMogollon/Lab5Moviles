using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Notification", order = 3)]
public class NotificationDataSO : ScriptableObject
{
    public string title;
    public int score;
    public int fireTimeInHours;
    public string smallIcon;
    public string largeIcon;

}
