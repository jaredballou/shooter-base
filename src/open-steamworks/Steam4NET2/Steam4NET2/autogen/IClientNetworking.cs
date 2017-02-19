// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientNetworkingVTable
	{
		public IntPtr SendP2PPacket0;
		public IntPtr IsP2PPacketAvailable1;
		public IntPtr ReadP2PPacket2;
		public IntPtr AcceptP2PSessionWithUser3;
		public IntPtr CloseP2PSessionWithUser4;
		public IntPtr CloseP2PChannelWithUser5;
		public IntPtr GetP2PSessionState6;
		public IntPtr AllowP2PPacketRelay7;
		public IntPtr CreateListenSocket8;
		public IntPtr CreateP2PConnectionSocket9;
		public IntPtr CreateConnectionSocket10;
		public IntPtr DestroySocket11;
		public IntPtr DestroyListenSocket12;
		public IntPtr SendDataOnSocket13;
		public IntPtr IsDataAvailableOnSocket14;
		public IntPtr RetrieveDataFromSocket15;
		public IntPtr IsDataAvailable16;
		public IntPtr RetrieveData17;
		public IntPtr GetSocketInfo18;
		public IntPtr GetListenSocketInfo19;
		public IntPtr GetSocketConnectionType20;
		public IntPtr GetMaxPacketSize21;
		private IntPtr DTorIClientNetworking22;
	};
	
	[InteropHelp.InterfaceVersion("ClientNetworking001")]
	public class IClientNetworking : InteropHelp.NativeWrapper<IClientNetworkingVTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendP2PPacketCBUEI( IntPtr thisptr, UInt64 steamIDRemote, Byte[] pubData, UInt32 cubData, EP2PSend eP2PSendType, Int32 iVirtualPort );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SendP2PPacket( CSteamID steamIDRemote, Byte[] pubData, EP2PSend eP2PSendType, Int32 iVirtualPort ) 
		{
			return this.GetFunction<NativeSendP2PPacketCBUEI>( this.Functions.SendP2PPacket0 )( this.ObjectAddress, steamIDRemote.ConvertToUint64(), pubData, (UInt32) pubData.Length, eP2PSendType, iVirtualPort ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsP2PPacketAvailableUI( IntPtr thisptr, ref UInt32 pcubMsgSize, Int32 iVirtualPort );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool IsP2PPacketAvailable( ref UInt32 pcubMsgSize, Int32 iVirtualPort ) 
		{
			return this.GetFunction<NativeIsP2PPacketAvailableUI>( this.Functions.IsP2PPacketAvailable1 )( this.ObjectAddress, ref pcubMsgSize, iVirtualPort ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeReadP2PPacketBUUCI( IntPtr thisptr, Byte[] pubDest, UInt32 cubDest, ref UInt32 pcubMsgSize, ref UInt64 psteamIDRemote, Int32 iVirtualPort );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool ReadP2PPacket( Byte[] pubDest, ref UInt32 pcubMsgSize, ref CSteamID psteamIDRemote, Int32 iVirtualPort ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeReadP2PPacketBUUCI>( this.Functions.ReadP2PPacket2 )( this.ObjectAddress, pubDest, (UInt32) pubDest.Length, ref pcubMsgSize, ref s0, iVirtualPort ); psteamIDRemote = new CSteamID(s0); return result;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeAcceptP2PSessionWithUserC( IntPtr thisptr, UInt64 steamIDRemote );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool AcceptP2PSessionWithUser( CSteamID steamIDRemote ) 
		{
			return this.GetFunction<NativeAcceptP2PSessionWithUserC>( this.Functions.AcceptP2PSessionWithUser3 )( this.ObjectAddress, steamIDRemote.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeCloseP2PSessionWithUserC( IntPtr thisptr, UInt64 steamIDRemote );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool CloseP2PSessionWithUser( CSteamID steamIDRemote ) 
		{
			return this.GetFunction<NativeCloseP2PSessionWithUserC>( this.Functions.CloseP2PSessionWithUser4 )( this.ObjectAddress, steamIDRemote.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeCloseP2PChannelWithUserCI( IntPtr thisptr, UInt64 steamIDRemote, Int32 iVirtualPort );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool CloseP2PChannelWithUser( CSteamID steamIDRemote, Int32 iVirtualPort ) 
		{
			return this.GetFunction<NativeCloseP2PChannelWithUserCI>( this.Functions.CloseP2PChannelWithUser5 )( this.ObjectAddress, steamIDRemote.ConvertToUint64(), iVirtualPort ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetP2PSessionStateCP( IntPtr thisptr, UInt64 steamIDRemote, ref P2PSessionState_t pConnectionState );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetP2PSessionState( CSteamID steamIDRemote, ref P2PSessionState_t pConnectionState ) 
		{
			return this.GetFunction<NativeGetP2PSessionStateCP>( this.Functions.GetP2PSessionState6 )( this.ObjectAddress, steamIDRemote.ConvertToUint64(), ref pConnectionState ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeAllowP2PPacketRelayB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bAllow );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool AllowP2PPacketRelay( bool bAllow ) 
		{
			return this.GetFunction<NativeAllowP2PPacketRelayB>( this.Functions.AllowP2PPacketRelay7 )( this.ObjectAddress, bAllow ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeCreateListenSocketIUUB( IntPtr thisptr, Int32 nVirtualP2PPort, UInt32 nIP, UInt16 nPort, [MarshalAs(UnmanagedType.I1)] bool bAllowUseOfPacketRelay );
		public UInt32 CreateListenSocket( Int32 nVirtualP2PPort, UInt32 nIP, UInt16 nPort, bool bAllowUseOfPacketRelay ) 
		{
			return this.GetFunction<NativeCreateListenSocketIUUB>( this.Functions.CreateListenSocket8 )( this.ObjectAddress, nVirtualP2PPort, nIP, nPort, bAllowUseOfPacketRelay ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeCreateP2PConnectionSocketCIIB( IntPtr thisptr, UInt64 steamIDTarget, Int32 nVirtualPort, Int32 nTimeoutSec, [MarshalAs(UnmanagedType.I1)] bool bAllowUseOfPacketRelay );
		public UInt32 CreateP2PConnectionSocket( CSteamID steamIDTarget, Int32 nVirtualPort, Int32 nTimeoutSec, bool bAllowUseOfPacketRelay ) 
		{
			return this.GetFunction<NativeCreateP2PConnectionSocketCIIB>( this.Functions.CreateP2PConnectionSocket9 )( this.ObjectAddress, steamIDTarget.ConvertToUint64(), nVirtualPort, nTimeoutSec, bAllowUseOfPacketRelay ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeCreateConnectionSocketUUI( IntPtr thisptr, UInt32 nIP, UInt16 nPort, Int32 nTimeoutSec );
		public UInt32 CreateConnectionSocket( UInt32 nIP, UInt16 nPort, Int32 nTimeoutSec ) 
		{
			return this.GetFunction<NativeCreateConnectionSocketUUI>( this.Functions.CreateConnectionSocket10 )( this.ObjectAddress, nIP, nPort, nTimeoutSec ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeDestroySocketUB( IntPtr thisptr, UInt32 hSocket, [MarshalAs(UnmanagedType.I1)] bool bNotifyRemoteEnd );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool DestroySocket( UInt32 hSocket, bool bNotifyRemoteEnd ) 
		{
			return this.GetFunction<NativeDestroySocketUB>( this.Functions.DestroySocket11 )( this.ObjectAddress, hSocket, bNotifyRemoteEnd ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeDestroyListenSocketUB( IntPtr thisptr, UInt32 hSocket, [MarshalAs(UnmanagedType.I1)] bool bNotifyRemoteEnd );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool DestroyListenSocket( UInt32 hSocket, bool bNotifyRemoteEnd ) 
		{
			return this.GetFunction<NativeDestroyListenSocketUB>( this.Functions.DestroyListenSocket12 )( this.ObjectAddress, hSocket, bNotifyRemoteEnd ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendDataOnSocketUBUB( IntPtr thisptr, UInt32 hSocket, Byte[] pubData, UInt32 cubData, [MarshalAs(UnmanagedType.I1)] bool bReliable );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SendDataOnSocket( UInt32 hSocket, Byte[] pubData, bool bReliable ) 
		{
			return this.GetFunction<NativeSendDataOnSocketUBUB>( this.Functions.SendDataOnSocket13 )( this.ObjectAddress, hSocket, pubData, (UInt32) pubData.Length, bReliable ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsDataAvailableOnSocketUU( IntPtr thisptr, UInt32 hSocket, ref UInt32 pcubMsgSize );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool IsDataAvailableOnSocket( UInt32 hSocket, ref UInt32 pcubMsgSize ) 
		{
			return this.GetFunction<NativeIsDataAvailableOnSocketUU>( this.Functions.IsDataAvailableOnSocket14 )( this.ObjectAddress, hSocket, ref pcubMsgSize ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRetrieveDataFromSocketUBUU( IntPtr thisptr, UInt32 hSocket, Byte[] pubDest, UInt32 cubDest, ref UInt32 pcubMsgSize );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool RetrieveDataFromSocket( UInt32 hSocket, Byte[] pubDest, ref UInt32 pcubMsgSize ) 
		{
			return this.GetFunction<NativeRetrieveDataFromSocketUBUU>( this.Functions.RetrieveDataFromSocket15 )( this.ObjectAddress, hSocket, pubDest, (UInt32) pubDest.Length, ref pcubMsgSize ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsDataAvailableUUU( IntPtr thisptr, UInt32 hListenSocket, ref UInt32 pcubMsgSize, ref UInt32 phSocket );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool IsDataAvailable( UInt32 hListenSocket, ref UInt32 pcubMsgSize, ref UInt32 phSocket ) 
		{
			return this.GetFunction<NativeIsDataAvailableUUU>( this.Functions.IsDataAvailable16 )( this.ObjectAddress, hListenSocket, ref pcubMsgSize, ref phSocket ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRetrieveDataUBUUU( IntPtr thisptr, UInt32 hListenSocket, Byte[] pubDest, UInt32 cubDest, ref UInt32 pcubMsgSize, ref UInt32 phSocket );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool RetrieveData( UInt32 hListenSocket, Byte[] pubDest, ref UInt32 pcubMsgSize, ref UInt32 phSocket ) 
		{
			return this.GetFunction<NativeRetrieveDataUBUUU>( this.Functions.RetrieveData17 )( this.ObjectAddress, hListenSocket, pubDest, (UInt32) pubDest.Length, ref pcubMsgSize, ref phSocket ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetSocketInfoUCIUU( IntPtr thisptr, UInt32 hSocket, ref UInt64 pSteamIDRemote, ref Int32 peSocketStatus, ref UInt32 punIPRemote, ref UInt16 punPortRemote );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetSocketInfo( UInt32 hSocket, ref CSteamID pSteamIDRemote, ref Int32 peSocketStatus, ref UInt32 punIPRemote, ref UInt16 punPortRemote ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeGetSocketInfoUCIUU>( this.Functions.GetSocketInfo18 )( this.ObjectAddress, hSocket, ref s0, ref peSocketStatus, ref punIPRemote, ref punPortRemote ); pSteamIDRemote = new CSteamID(s0); return result;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetListenSocketInfoUUU( IntPtr thisptr, UInt32 hListenSocket, ref UInt32 pnIP, ref UInt16 pnPort );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetListenSocketInfo( UInt32 hListenSocket, ref UInt32 pnIP, ref UInt16 pnPort ) 
		{
			return this.GetFunction<NativeGetListenSocketInfoUUU>( this.Functions.GetListenSocketInfo19 )( this.ObjectAddress, hListenSocket, ref pnIP, ref pnPort ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ESNetSocketConnectionType NativeGetSocketConnectionTypeU( IntPtr thisptr, UInt32 hSocket );
		public ESNetSocketConnectionType GetSocketConnectionType( UInt32 hSocket ) 
		{
			return this.GetFunction<NativeGetSocketConnectionTypeU>( this.Functions.GetSocketConnectionType20 )( this.ObjectAddress, hSocket ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetMaxPacketSizeU( IntPtr thisptr, UInt32 hSocket );
		public Int32 GetMaxPacketSize( UInt32 hSocket ) 
		{
			return this.GetFunction<NativeGetMaxPacketSizeU>( this.Functions.GetMaxPacketSize21 )( this.ObjectAddress, hSocket ); 
		}
		
	};
}
