﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPC.Message
{
	/// <summary>
	/// Failed to establish any connection with discord. Discord is potentially not running?
	/// </summary>
	public class ConnectionFailedMessage : IMessage
	{
		public override MessageType Type { get { return MessageType.ConnectionFailed; } }

		/// <summary>
		/// The pipe we failed to connect too.
		/// </summary>
		public int FailedPipe { get; internal set; }
	}
}
