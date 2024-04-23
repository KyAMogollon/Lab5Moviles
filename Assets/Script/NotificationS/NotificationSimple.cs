using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

#if UNITY_ANDROID
using Unity.Notifications.Android;
using UnityEngine.Android;
#endif

public class NotificationSimple : MonoBehaviour
{
    private const string idCanal = "canalNotificacion";

    private void Start()
    {
#if UNITY_ANDROID
        RequestAuhtorization();
        RegisterNotificationChannel();
#endif
    }

#if UNITY_ANDROID
    //Request authorization to send notifications
    public void RequestAuhtorization()
    {
        if(!Permission.HasUserAuthorizedPermission("android.permission.POST_NOTIFICATIONS"))
        {
            Permission.RequestUserPermission("android.permission.POST_NOTIFICATIONS");
        }
    }

    //Register a Notification Channel
    public void RegisterNotificationChannel()
    {
        AndroidNotificationChannel channel = new AndroidNotificationChannel
        {
            Id = "default_channel",
            Name = "Default",
            Importance = Importance.Default,
            Description = "Notifications"
        };

        AndroidNotificationCenter.RegisterNotificationChannel(channel);
    }

    //Set Up Notification Template
    public void SendNotificationCurrentScore(NotificationDataSO dataSO)
    {
        AndroidNotification notification = new AndroidNotification();
        notification.Title = dataSO.title;
        notification.Text = "Tu puntaje actual fue de " + dataSO.score + "pts";
        notification.FireTime = DateTime.Now.AddSeconds(dataSO.fireTimeInHours);
        notification.SmallIcon = dataSO.smallIcon;
        notification.LargeIcon = dataSO.largeIcon;

        AndroidNotificationCenter.SendNotification(notification, "default_channel");
    }
    public void SendNotificationHightScore(NotificationDataSO dataSO)
    {
        AndroidNotification notification = new AndroidNotification();
        notification.Title = dataSO.title;
        notification.Text = "Tu puntaje maximo fue de " + dataSO.score + "pts";
        notification.FireTime = DateTime.Now.AddSeconds(dataSO.fireTimeInHours);
        notification.SmallIcon = dataSO.smallIcon;
        notification.LargeIcon = dataSO.largeIcon;

        AndroidNotificationCenter.SendNotification(notification, "default_channel");
    }

    //public void ButtonFunction()
    //{
    //    SendNotificationCurrentScore("Dummy Notification", "This is a sample Notification", 0);
    //}
#endif
}
