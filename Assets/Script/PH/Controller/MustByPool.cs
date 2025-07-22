using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MustByPool
{
    private static MustByPool instance;
    public static MustByPool Textural    {
        get
        {
            instance ??= new MustByPool();
            return instance;
        }
    }

    /// <summary>
    /// 打开引导弹窗
    /// </summary>
    /// <returns></returns>
    public bool WifeMustByKrill()
    {
        // 判断是否可以打开引导弹窗
        UnwarySovietAnvil config = UnwarySovietPool.Textural.UnwarySoviet;
        if (config.gameReviewGuide == null || config.gameReviewGuide.isOpenReviewGuide == 0)
        {
            return false;
        }

        PHUIAbsence.Textural.HeelUIDrape("MustUsKrill");
        return true;
    }
}
