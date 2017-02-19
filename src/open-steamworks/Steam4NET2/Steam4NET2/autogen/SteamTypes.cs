// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	public enum ShareType_t : int
	{
		SHARE_STOPIMMEDIATELY = 0,
		SHARE_RATIO = 1,
		SHARE_MANUAL = 2,
	};
	
	public enum EChatSteamIDInstanceFlags : int
	{
		k_EChatAccountInstanceMask = 4095,
		k_EChatInstanceFlagClan = 524288,
		k_EChatInstanceFlagLobby = 262144,
		k_EChatInstanceFlagMMSLobby = 131072,
	};
	
	public enum ECallbackType : int
	{
		k_iSteamUserCallbacks = 100,
		k_iSteamGameServerCallbacks = 200,
		k_iSteamFriendsCallbacks = 300,
		k_iSteamBillingCallbacks = 400,
		k_iSteamMatchmakingCallbacks = 500,
		k_iSteamContentServerCallbacks = 600,
		k_iSteamUtilsCallbacks = 700,
		k_iClientFriendsCallbacks = 800,
		k_iClientUserCallbacks = 900,
		k_iSteamAppsCallbacks = 1000,
		k_iSteamUserStatsCallbacks = 1100,
		k_iSteamNetworkingCallbacks = 1200,
		k_iClientRemoteStorageCallbacks = 1300,
		k_iSteamUserItemsCallbacks = 1400,
		k_iSteamGameServerItemsCallbacks = 1500,
		k_iClientUtilsCallbacks = 1600,
		k_iSteamGameCoordinatorCallbacks = 1700,
		k_iSteamGameServerStatsCallbacks = 1800,
		k_iSteam2AsyncCallbacks = 1900,
		k_iSteamGameStatsCallbacks = 2000,
		k_iClientHTTPCallbacks = 2100,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct CallbackMsg_t
	{
		public Int32 m_hSteamUser;
		public Int32 m_iCallback;
		public IntPtr m_pubParam;
		public Int32 m_cubParam;
	};
	
}
