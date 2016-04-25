﻿using System;

namespace Library
{
    public class Message : Model
	{
		public static class MessageType
		{
			public const String IN_APP = "inapp";
			public const String EMAIL = "email";
		}

		public static class MessageTemplate
		{
			public const String PLAIN = "plain";
			public const String PERSONAL = "email";
		}

		public static class MessageFromOrToType
		{
			public const String USER = "user";
			public const String ADMIN = "admin";
			public const String CONTACT = "contact";
		}

		public virtual string body { get; set; }

        public Message ()
		{
		}
	}
}