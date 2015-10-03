﻿using MadTVDB.Models;
using System.Threading.Tasks;

namespace MadTVDB
{
    public class MadTVDB
    {
        private TVDBData _tvdbData;

        /// <summary>
        ///     This will be the main class, handling all of the user's requests  
        /// </summary>
        /// <param name="apiKey">Your API key that is provided by The TVDB.</param>
        public MadTVDB(string apiKey)
        {
            // create a new instance of the tvdbdata thingy
            _tvdbData = new TVDBData(apiKey);
        }

        public async Task<TVDBSearchResponse> Search(string query)
        {
            TVDBSearchResponse searchResponse = await _tvdbData.Search(query);
            return searchResponse;
        }
    }
}