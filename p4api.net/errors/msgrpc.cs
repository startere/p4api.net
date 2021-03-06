using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace Perforce.P4
{
	public partial class P4ClientError
	{
		public static int MsgRpc_Closed = ErrorOf(ErrorSubsystem.ES_RPC, 1, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"Partner exited unexpectedly."
		public static int MsgRpc_Listen = ErrorOf(ErrorSubsystem.ES_RPC, 3, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"Listen %address% failed."
		public static int MsgRpc_NoPoss = ErrorOf(ErrorSubsystem.ES_RPC, 5, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"Required positional parameter missing."
		public static int MsgRpc_NotP4 = ErrorOf(ErrorSubsystem.ES_RPC, 6, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"RpcTransport: partner is not a Perforce client/server."
		public static int MsgRpc_BadOrder = ErrorOf(ErrorSubsystem.ES_RPC, 74, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"Rpc: partner violated message ordering rules for %func%."
		public static int MsgRpc_Operat = ErrorOf(ErrorSubsystem.ES_RPC, 7, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"Operation '%operation%' failed."
		public static int MsgRpc_Read = ErrorOf(ErrorSubsystem.ES_RPC, 8, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"RpcTransport: partial message read"
		public static int MsgRpc_Select = ErrorOf(ErrorSubsystem.ES_RPC, 61, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"Select call failed with error: %error%."
		public static int MsgRpc_Reconn = ErrorOf(ErrorSubsystem.ES_RPC, 9, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"Can't connect an existing connection!"
		public static int MsgRpc_Stdio = ErrorOf(ErrorSubsystem.ES_RPC, 10, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"Can't make outbound connection via stdio!"
		public static int MsgRpc_TcpAccept = ErrorOf(ErrorSubsystem.ES_RPC, 11, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"TCP connection accept failed."
		public static int MsgRpc_TcpConnect = ErrorOf(ErrorSubsystem.ES_RPC, 12, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"TCP connect to %host% failed."
		public static int MsgRpc_TcpHost = ErrorOf(ErrorSubsystem.ES_RPC, 13, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"%host%: host unknown."
		public static int MsgRpc_TcpListen = ErrorOf(ErrorSubsystem.ES_RPC, 14, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"TCP listen on %service% failed."
		public static int MsgRpc_TcpPortInvalid = ErrorOf(ErrorSubsystem.ES_RPC, 22, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"TCP port number %service% is out of range."
		public static int MsgRpc_TcpRecv = ErrorOf(ErrorSubsystem.ES_RPC, 15, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"TCP receive failed."
		public static int MsgRpc_TcpSend = ErrorOf(ErrorSubsystem.ES_RPC, 16, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"TCP send failed."
		public static int MsgRpc_TcpService = ErrorOf(ErrorSubsystem.ES_RPC, 17, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"%service%: service unknown."
		public static int MsgRpc_TcpPeerSsl = ErrorOf(ErrorSubsystem.ES_RPC, 31, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"Failed client SSL connection setup, server not using SSL."
		public static int MsgRpc_TooBig = ErrorOf(ErrorSubsystem.ES_RPC, 18, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"Rpc buffer too big to send!"
		public static int MsgRpc_UnReg = ErrorOf(ErrorSubsystem.ES_RPC, 19, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 1); //"Internal function '%function%' unregistered!"
		public static int MsgRpc_Unconn = ErrorOf(ErrorSubsystem.ES_RPC, 20, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"Connection attempt on unopened rpc!"
		public static int MsgRpc_Break = ErrorOf(ErrorSubsystem.ES_RPC, 21, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"TCP receive interrupted by client."
		public static int MsgRpc_MaxWait = ErrorOf(ErrorSubsystem.ES_RPC, 39, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 2); //"TCP %operation% exceeded maximum configured duration of %seconds% seconds."
		public static int MsgRpc_NameResolve = ErrorOf(ErrorSubsystem.ES_RPC, 37, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"%errortext%"
		public static int MsgRpc_SslAccept = ErrorOf(ErrorSubsystem.ES_RPC, 38, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"SSL connection accept failed %error%.\n\tClient must add SSL protocol prefix to P4PORT."
		public static int MsgRpc_SslConnect = ErrorOf(ErrorSubsystem.ES_RPC, 23, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 2); //"SSL connect to %host% failed %error%.\n\tRemove SSL protocol prefix from P4PORT or fix the TLS settings."
		public static int MsgRpc_SslListen = ErrorOf(ErrorSubsystem.ES_RPC, 24, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"SSL listen on %service% failed."
		public static int MsgRpc_SslRecv = ErrorOf(ErrorSubsystem.ES_RPC, 25, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"SSL receive failed."
		public static int MsgRpc_SslSend = ErrorOf(ErrorSubsystem.ES_RPC, 26, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"SSL send failed."
		public static int MsgRpc_SslClose = ErrorOf(ErrorSubsystem.ES_RPC, 27, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"SSL close failed."
		public static int MsgRpc_SslInvalid = ErrorOf(ErrorSubsystem.ES_RPC, 28, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"Invalid operation for SSL on %service%."
		public static int MsgRpc_SslCtx = ErrorOf(ErrorSubsystem.ES_RPC, 29, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"Fail create ctx on %service%."
		public static int MsgRpc_SslShutdown = ErrorOf(ErrorSubsystem.ES_RPC, 30, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"SSL read/write failed since in Shutdown."
		public static int MsgRpc_SslInit = ErrorOf(ErrorSubsystem.ES_RPC, 32, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"Failed to initialize SSL library."
		public static int MsgRpc_SslCleartext = ErrorOf(ErrorSubsystem.ES_RPC, 33, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"Failed client connect, server using SSL.\nClient must add SSL protocol prefix to P4PORT."
		public static int MsgRpc_SslCertGen = ErrorOf(ErrorSubsystem.ES_RPC, 34, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"Unable to generate certificate or private key for server."
		public static int MsgRpc_SslNoSsl = ErrorOf(ErrorSubsystem.ES_RPC, 35, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"Trying to use SSL when SSL library has not been compiled into program."
		public static int MsgRpc_SslBadKeyFile = ErrorOf(ErrorSubsystem.ES_RPC, 36, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"Either privatekey.txt or certificate.txt files do not exist."
		public static int MsgRpc_SslGetPubKey = ErrorOf(ErrorSubsystem.ES_RPC, 40, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"Unable to get public key for token generation."
		public static int MsgRpc_SslBadDir = ErrorOf(ErrorSubsystem.ES_RPC, 41, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"P4SSLDIR not defined or does not reference a valid directory."
		public static int MsgRpc_SslBadFsSecurity = ErrorOf(ErrorSubsystem.ES_RPC, 42, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"P4SSLDIR directory or key and certificate files not secure."
		public static int MsgRpc_SslDirHasCreds = ErrorOf(ErrorSubsystem.ES_RPC, 43, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"P4SSLDIR contains credentials, please remove key and certificate files."
		public static int MsgRpc_SslCredsBadOwner = ErrorOf(ErrorSubsystem.ES_RPC, 44, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"P4SSLDIR or credentials files not owned by Perforce process effective user."
		public static int MsgRpc_SslCertBadDates = ErrorOf(ErrorSubsystem.ES_RPC, 45, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"Certificate date range invalid."
		public static int MsgRpc_SslNoCredentials = ErrorOf(ErrorSubsystem.ES_RPC, 46, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"SSL credentials do not exist."
		public static int MsgRpc_SslFailGetExpire = ErrorOf(ErrorSubsystem.ES_RPC, 47, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"Failed to get certificate's expiration date."
		public static int MsgRpc_HostKeyUnknown = ErrorOf(ErrorSubsystem.ES_RPC, 48, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 3); //"The authenticity of '%host%' can't be established,\n"
		public static int MsgRpc_HostKeyMismatch = ErrorOf(ErrorSubsystem.ES_RPC, 49, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 3); //"******* WARNING P4PORT IDENTIFICATION HAS CHANGED! *******\n"
		public static int MsgRpc_ServiceNoTrust = ErrorOf(ErrorSubsystem.ES_RPC, 50, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"%server% cannot forward your request; target failed SSL/trust verification."
		public static int MsgRpc_SslLibMismatch = ErrorOf(ErrorSubsystem.ES_RPC, 51, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"SSL library must be at least version %sslversion%."
		public static int MsgRpc_PxRemoteSvrFail = ErrorOf(ErrorSubsystem.ES_RPC, 52, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"Proxy unable to communicate with remote server:"
		public static int MsgRpc_SslCfgExpire = ErrorOf(ErrorSubsystem.ES_RPC, 53, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"Certificate config.txt: invalid EX value \"
		public static int MsgRpc_SslCfgUnits = ErrorOf(ErrorSubsystem.ES_RPC, 54, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"Certificate config.txt: invalid UNITS value, must be either secs, mins, hours, or days."
		public static int MsgRpc_SslKeyNotRSA = ErrorOf(ErrorSubsystem.ES_RPC, 55, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 0); //"Fail load key, not of type RSA."
		public static int MsgRpc_SslProtocolError = ErrorOf(ErrorSubsystem.ES_RPC, 56, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"SSL protocol: %errortext%"
		public static int MsgRpc_WakeupInit = ErrorOf(ErrorSubsystem.ES_RPC, 62, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 2); //"Fail to setup wake-up socket during %function% with error: %error%."
		public static int MsgRpc_WakeupAttempt = ErrorOf(ErrorSubsystem.ES_RPC, 63, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 2); //"Fail wake-up attempt in %function% with error: %error%."
		public static int MsgRpc_ZksInit = ErrorOf(ErrorSubsystem.ES_RPC, 64, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 2); //"Fail to setup p4zk socket during %function% with error: %error%."
		public static int MsgRpc_ZksSend = ErrorOf(ErrorSubsystem.ES_RPC, 65, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"Fail to send on p4zk socket with error: %error%."
		public static int MsgRpc_ZksRecv = ErrorOf(ErrorSubsystem.ES_RPC, 66, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 1); //"Fail to receive on p4zk socket with error: %error%."
		public static int MsgRpc_ZksDisconnect = ErrorOf(ErrorSubsystem.ES_RPC, 67, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"Cluster lifeline connection to p4zk closed, must shutdown."
		public static int MsgRpc_ZksState = ErrorOf(ErrorSubsystem.ES_RPC, 68, ErrorSeverity.E_FAILED, ErrorGeneric.EV_COMM, 3); //"p4zk connection state incorrect for %function%, expected %state1%, found %state2%"
		public static int MsgRpc_ZksNoZK = ErrorOf(ErrorSubsystem.ES_RPC, 73, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 1); //"p4zk unable to register with Zookeeper Servers: %place%."
		public static int MsgRpc_UnixDomainOpen = ErrorOf(ErrorSubsystem.ES_RPC, 69, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 2); //"Fail to setup Unix-domain socket during %function% with error: %error%."
		public static int MsgRpc_BadP4Port = ErrorOf(ErrorSubsystem.ES_RPC, 70, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 1); //"P4PORT for this server is not valid: %p4port%."
		public static int MsgRpc_NoHostnameForPort = ErrorOf(ErrorSubsystem.ES_RPC, 71, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"Cannot find hostname to use for P4PORT."
		public static int MsgRpc_NoConnectionToZK = ErrorOf(ErrorSubsystem.ES_RPC, 72, ErrorSeverity.E_FATAL, ErrorGeneric.EV_COMM, 0); //"Cannot connect to p4zk."
	}
}
