using UnityEngine;
using Landfall.TABS;
class NetworkLogger
{
	static void Start()
	{
        Debug.Log("Start called!");
		JMTK.instance.useNetworkLogger = true;
	}
    static void Remove()
	{
        Debug.Log("Remove called!");
		JMTK.instance.useNetworkLogger = false;
	}
}
