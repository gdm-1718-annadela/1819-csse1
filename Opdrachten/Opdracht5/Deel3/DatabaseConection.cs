class DatabaseConection
{
  private static DatabaseConection _instance;
  private List<string> _servers = new List<string>();
  private Random _random = new Random();
 
    // Lock synchronization object

  private static object syncLock = new object();
 
    // Constructor (protected)

  protected DatabaseConection()
    {
      // List of available servers

      _servers.Add("ServerI");
      _servers.Add("ServerII");
      _servers.Add("ServerIII");
      _servers.Add("ServerIV");
      _servers.Add("ServerV");
    }
 
    public static DatabaseConection GetDatabaseConection()
    {
      if (_instance == null)
      {
        lock (syncLock)
        {
          if (_instance == null)
          {
            _instance = new DatabaseConection();
          }
        }
      }
 
      return _instance;
    }
    
    public string Server
    {
      get

      {
        int r = _random.Next(_servers.Count);
        return _servers[r].ToString();
      }
    }
  }
}