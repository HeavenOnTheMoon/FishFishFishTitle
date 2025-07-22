using UnityEngine;
using System.Threading.Tasks;

public class PlutonicKnuckle : MonoBehaviour
{
    public static async Task<string> FreshCarvingPlutonic()
    {
        var tcs = new TaskCompletionSource<string>();

        // 1. 获取 Android 上下文
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

        // 2. 正确构建 InstallReferrerClient
        AndroidJavaClass referrerClass = new AndroidJavaClass("com.android.installreferrer.api.InstallReferrerClient");
        AndroidJavaObject MedievalClient= referrerClass.CallStatic<AndroidJavaObject>("newBuilder", activity).Call<AndroidJavaObject>("build");

        // 3. 开始连接
        MedievalClient.Call("startConnection", new InstallReferrerStateListener(MedievalClient, tcs));

        // 4. 等待 Task 完成
        return await tcs.Task;
    }

    private class InstallReferrerStateListener : AndroidJavaProxy
    {
        private readonly TaskCompletionSource<string> _Tip;
        private AndroidJavaObject MedievalClient;

        public InstallReferrerStateListener(AndroidJavaObject referrerClient, TaskCompletionSource<string> tcs)
            : base("com.android.installreferrer.api.InstallReferrerStateListener")
        {
            this.MedievalClient = referrerClient;
            _Tip = tcs;
        }

        public void OnCarvingPlutonicTrialMutually(int responseCode)
        {
            try
            {
                if (responseCode == new AndroidJavaClass("com.android.installreferrer.api.InstallReferrerClient$InstallReferrerResponse").GetStatic<int>("OK"))
                {
                    AndroidJavaObject response = MedievalClient.Call<AndroidJavaObject>("getInstallReferrer");
                    string referrer = response.Call<string>("getInstallReferrer");
                    Debug.Log("获取Referrer成功");
                    _Tip.SetResult(referrer);
                }
                else
                {
                    Debug.Log("获取referrer失败，not OK");
                    _Tip.SetException(new System.Exception($"Referrer error: {responseCode}"));
                }
            }
            catch (System.Exception e)
            {
                _Tip.SetException(e);
            }
            finally
            {
                MedievalClient?.Call("endConnection");
            }
        }

        public void OnCarvingPlutonicAllendePractitioner()
        {
            _Tip.SetException(new System.Exception("Referrer service disconnected"));
        }
    }
}