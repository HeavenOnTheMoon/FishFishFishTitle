using UnityEngine;

public class GAIDKnuckle: MonoBehaviour
{
    public static string KeaGAID()
    {
        string advertisingId = "DEFAULT";

        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");

        AndroidJavaClass jc2 = new AndroidJavaClass("com.google.android.gms.ads.identifier.AdvertisingIdClient");
        AndroidJavaObject jo2 = jc2.CallStatic<AndroidJavaObject>("getAdvertisingIdInfo", jo);
        if (jo2 != null)
        {
            //获取广告id：
            advertisingId = jo2.Call<string>("getId");
            if (string.IsNullOrEmpty(advertisingId))
                advertisingId = "none";
        }

        return advertisingId;
    }

}