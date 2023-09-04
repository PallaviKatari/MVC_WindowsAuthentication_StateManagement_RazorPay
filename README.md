1. AccountController - GoogleOAuth Steps

 -> https://console.cloud.google.com/apis/ - Credentials - Create Credentials - Create OAuth client ID - Generates Client ID and Client Secret Key
 -> Include the below in App_Start - AuthConfig.cs
   public static void RegisterAuth()
        {
            GoogleOAuth2Client clientGoog = new GoogleOAuth2Client("303346449770-56juh8bkbe3pbghj8mu21ek9c82jajh4.apps.googleusercontent.com", "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");
            IDictionary<string, string> extraData = new Dictionary<string, string>();            
            OpenAuth.AuthenticationClients.Add("google", () => clientGoog, extraData);
        }
   -> Follow the logic in AccountController

2. CODE FIRST APPROACH - MoviesController

  -> Create Movie.cs and MvcMovieContext.cs in Models Directory
  -> Configure connnectionStrings in web.config - Initial Catalog - DB Name
  -> Create MoviesController and corresponding views
  -> Run application - Database get automatically in LocalDB
  -> To view LocalDB - View - SQL Server Object Explorer - Refresh the LocalDB - The name given in the initial catalog gets generated as a database

