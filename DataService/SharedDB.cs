using ChatApplication.ChatService.Models;
using System.Collections.Concurrent;

namespace ChatApplication.ChatService.DataService
{
    public class SharedDB
    {
        private readonly ConcurrentDictionary<string, UserConnection> _connections = new ();

        public ConcurrentDictionary<string, UserConnection> connections => _connections;
    }
}
