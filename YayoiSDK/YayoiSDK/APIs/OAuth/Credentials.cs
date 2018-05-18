namespace YayoiSDK.APIs.OAuth
{
	/// <summary>
	/// Yayoi 認証データ基底クラス
	/// </summary>
	public class Credentials
	{

		#region Constractor 

		// インスタンス生成用
		public Credentials(string clientKey, string clientSecret)
		{
			this.ClientKey = clientKey;
			this.ClientSecret = clientSecret;
		}

		// Setting File用
		public Credentials(string clientKey, string clientSecret, string accessToken, string refreshToken)
		{
			this.ClientKey = clientKey;
			this.ClientSecret = clientSecret;
			this.AccessToken = accessToken;
			this.RefreshToken = refreshToken;
		}

		#endregion

		#region Properties.

		/// <summary>
		/// Client Key の管理を行います。
		///※ 認証キーの保持・参照タイミング的に Mutable Property にする必要あり。
		/// </summary>
		public string ClientKey { get; set; }

		/// <summary>
		/// Client Secret の管理を行います。
		///※ 認証キーの保持・参照タイミング的に Mutable Property にする必要あり。
		/// </summary>
		public string ClientSecret { get; set; }

		/// <summary>
		/// Access Token の管理を行います。
		///※ 認証キーの保持・参照タイミング的に Mutable Property にする必要あり。
		/// </summary>
		public string AccessToken { get; set; }

		/// <summary>
		/// Refresh Token の管理を行います。
		///※ 認証キーの保持・参照タイミング的に Mutable Property にする必要あり。
		/// </summary>
		public string RefreshToken { get; set; }

		/// <summary>
		/// Account Id の管理を行います。
		///※ 認証キーの保持・参照タイミング的に Mutable Property にする必要あり。
		/// </summary>
		public string AccountId { get; set; }

		/// <summary>
		/// Display Name の管理を行います。
		///※ 認証キーの保持・参照タイミング的に Mutable Property にする必要あり。
		/// </summary>
		public string DisplayName { get; set; }

		/// <summary>
		/// Pin Code の管理を行います。
		///※ 認証キーの保持・参照タイミング的に Mutable Property にする必要あり。
		/// </summary>
		public string PinCode { get; set; }

		#endregion

	}
}
