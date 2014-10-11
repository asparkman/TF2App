using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Steam.WebAPI
{
	public class SteamClient
	{
		public SteamClient()
		{
			_client = new HttpClient();
			
		}

		private HttpClient _client { get; set; }

		#region General interfaces
		#region ISteamApps - Methods relating to Steam Apps in general.
		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetAppList
		/// Full list of every publicly facing program in the store/library.
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetAppList()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetServersAtAddress
		/// Shows all steam-compatible servers related to a IPv4 Address.
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetServersAtAddress()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/UpToDateCheck
		/// Check if a given app version is the most current available.
		/// </summary>
		public virtual async Task<HttpResponseMessage> UpToDateCheck()
		{
			throw new NotImplementedException();
		}
		#endregion

		#region ISteamEconomy - Methods relating to games' store's assets.
		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetAssetClassInfo
		/// Asset metadata
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetAssetClassInfo()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetAssetPrices
		/// Prices of items in the economy.
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetAssetPrices()
		{
			throw new NotImplementedException();
		}
		#endregion

		#region ISteamNews - Methods relating to Steam News.
		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetNewsForApp
		/// News feed for various games
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetNewsForApp()
		{
			throw new NotImplementedException();
		}
		#endregion

		#region ISteamRemoteStorage - Methods relating to stored files.
		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetCollectionDetails
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetCollectionDetails()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetPublishedFileDetails
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetPublishedFileDetails()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetUGCFileDetails
		/// UGC file size, local filename, and URL.
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetUGCFileDetails()
		{
			throw new NotImplementedException();
		}
		#endregion

		#region ISteamUser - Methods relating to Steam users.
		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetFriendList
		/// User friend list
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetFriendList()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetPlayerBans
		/// Player ban/probation status
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetPlayerBans()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetPlayerSummaries
		/// User profile data
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetPlayerSummaries()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetUserGroupList
		/// Lists Group ID(s) linked with 64 bit ID
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetUserGroupList()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/ResolveVanityURL
		/// Resolve vanity URL parts to a 64 bit ID.
		/// </summary>
		public virtual async Task<HttpResponseMessage> ResolveVanityURL()
		{
			throw new NotImplementedException();
		}
		#endregion

		#region ISteamUserStats - Methods relating to User stats.
		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetGlobalAchievementPercentagesForApp
		/// Statistics showing how much of the player base have unlocked various achievements.
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetGlobalAchievementPercentagesForApp()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetGlobalStatsForGame
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetGlobalStatsForGame()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetNumberOfCurrentPlayers
		/// Returns the current number of players for an app.
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetNumberOfCurrentPlayers()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetPlayerAchievements
		/// Game achievements
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetPlayerAchievements()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetSchemaForGame
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetSchemaForGame()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetUserStatsForGame
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetUserStatsForGame()
		{
			throw new NotImplementedException();
		}
		#endregion

		#region IPlayerService - Methods relating to a Steam user's games.
		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetRecentlyPlayedGames
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetRecentlyPlayedGames()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetOwnedGames
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetOwnedGames()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetSteamLevel
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetSteamLevel()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetBadges
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetBadges()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetCommunityBadgeProgress
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetCommunityBadgeProgress()
		{
			throw new NotImplementedException();
		}
		#endregion

		#region ISteamWebAPIUtil - Methods relating to the WebAPI itself.
		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetServerInfo
		/// Returns WebAPI server time &amp; checks server status.
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetServerInfo()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetSupportedAPIList
		/// Lists all available WebAPI interfaces.
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetSupportedAPIList()
		{
			throw new NotImplementedException();
		}
		#endregion
		#endregion

		#region Generic interfaces
		#region IEconItems_<ID> - Methods relating to in-game items for supported games.
		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetPlayerItems
		/// Lists items in a player's backpack.
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetPlayerItems()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetSchema
		/// Information about the items in a supporting game.
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetSchema()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetSchemaURL
		/// Returns a URL for the games' item_game.txt file.
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetSchemaURL()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// https://wiki.teamfortress.com/wiki/WebAPI/GetStoreMetadata
		/// Information about the game's store.
		/// </summary>
		public virtual async Task<HttpResponseMessage> GetStoreMetadata()
		{
			throw new NotImplementedException();
		}
		#endregion
		#endregion

	}
}
