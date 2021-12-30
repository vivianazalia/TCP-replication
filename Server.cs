using System;

namespace Server
{
	public class Login
	{
		public struct LoginInfo
		{
			string username;
			int id;
		}
	}

	public class Player
	{
		LoginInfo info;

		public void Play()
		{
			LoginInfo infoLogin = new LoginInfo { username = "Aaa", id = 1 };
			Player player = new Player { info = infoLogin }
		}
	}
}


