using UnityEngine;
using OneSignalSDK;
using OneSignalSDK.Debug.Models;

public class OneSignalInit : MonoBehaviour
{
    async void Start()
    {
        // Enable verbose logging for debugging (remove in production)
        OneSignal.Debug.LogLevel = LogLevel.Verbose;
        // Initialize with your OneSignal App ID
        OneSignal.Initialize("51ffc8ba-3b81-4f13-aabe-4de0d6332e3a");
        // Use this method to prompt for push notifications.
        // We recommend removing this method after testing and instead use In-App Messages to prompt for notification permission.
        await OneSignal.Notifications.RequestPermissionAsync(true);
    }
}
