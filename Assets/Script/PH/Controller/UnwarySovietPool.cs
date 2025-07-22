using System.Threading.Tasks;
using UnityEngine;

public class UnwarySovietPool
{
    private static UnwarySovietPool instance;
    public static UnwarySovietPool Textural    {
        get
        {
            instance ??= new UnwarySovietPool();
            return instance;
        }
    }

    public UnwarySovietAnvil UnwarySoviet{ get; private set; }

    public async Task<bool> FreshUnwarySoviet()
    {
        int appBuildVersion = BurrowPool.Textural.MayDoubtRut;
        string Air= $"{PHGloss.BASE_URL}/api/game/appversionconfig/ph?appBuildVersion={appBuildVersion}";
        var response = await BitePrevailPool.Textural.Kea(Air, true, false);
        if (response.IsSuccess)
        {
            var responseData = response.GetData<HttpResponseData<HttpReponseServerConfigModel>>();
            HttpReponseServerConfigModel config = responseData.data;
            if(config == null || config.list == null || config.list.Count == 0)
            {
                Debug.LogError("未正常获取配置");
                return false;
            }
            UnwarySoviet = new UnwarySovietAnvil(config.list);
            return true;
        }
        else
        {
            return false;
        }
    }
}
