using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aptitude_test
{
    public class User
    {
        private readonly FakeDataStore _fakeDataStore;
        public User()
        {
            _fakeDataStore = FakeDataStore.Instance;
        }
        public void Add(string userName)
        {
            if (!string.IsNullOrWhiteSpace(userName))
            {
                _fakeDataStore.Add(userName);
            }
        }

        public int GetUserCount()
        {
            return _fakeDataStore.GetUserCount();
        }
    }

    public class FakeDataStore
    {
        private static FakeDataStore instance;

        private FakeDataStore() { }

        public static FakeDataStore Instance
        {
            get
            {
                if (instance == null)
                {
                    _users = new List<string> { };
                    instance = new FakeDataStore();
                }
                return instance;
            }
        }
        private static List<string> _users;
        public void Add(string userName)
        {
            if (!string.IsNullOrWhiteSpace(userName))
            {
                _users.Add(userName);
            }
        }

        public int GetUserCount()
        {
            return _users.Count();
        }
    }
}
