using Microsoft.AspNetCore.Http;
using System.Linq;

namespace Architecture.Core.WebMVC.Implementation
{
    public class SessionManager
    {
        private readonly Microsoft.AspNetCore.Http.HttpContext _context;
        public SessionManager(Microsoft.AspNetCore.Http.HttpContext context)
        {
            _context = context;
        }


        private const string _currentUserKey = "CurrentUser";
        public string CurrentUser
        {
            get => GetStringValue(_currentUserKey);
            set => _context.Session.SetString(_currentUserKey, value);
        }

        private string GetStringValue(string sessionKey)
        {
            if (_context?.Session != null && _context.Session.IsAvailable && _context.Session.Keys != null && _context.Session.Keys.ToList().Contains(sessionKey))
                return _context.Session.GetString(sessionKey);

            return null;
        }
    }
}
