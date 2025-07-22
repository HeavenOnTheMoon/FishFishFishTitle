using UnityEngine;

#if Old_UIFramework
public class PrevailDrynessKrill : MoteUIDrape
#elif New_UIFramework
public class PrevailDrynessKrill : BaseUI
#else
public class PrevailDrynessKrill : MonoBehaviour
#endif
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
