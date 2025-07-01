using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace healthy.Models
{
    internal class SupabaseClient
    {
        // 連線登入 Supabase 共用函式
        public Supabase.Client GetClient()
        {
            // 初始化 Supabase 客戶端
            Supabase.Client _client;
            _client = new Supabase.Client(
                "https://你的Project ID.supabase.co",
                "你的API Key",
                new Supabase.SupabaseOptions { AutoConnectRealtime = true });
            return _client;
        }
    }
}
