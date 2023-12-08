
# Get ready the app
    - Go to the Microsoft Entra ID  in my case it was Default Dirctory | Overview
      Tenant ID should be there already. 
    - Register a new App using App Registrations menu on the left 
      So new instance of a app will be created , apparently Client ID will be generated. 
    - Staying From newly created Graph API app as part of app registrations 
          - Set Permission to the app itself from Api Permission Menu
          - Create Secret for this app So the Secret value can be get from Here. 


    At this state we get all required value 
          - Tenant ID : belongs to EntraID
          - Client ID : got as a result of app registrations
          _ Secret Value: secret belongs to the app
   
          - Now GraphServiceClient can be created to the console app in Visual Studio
          - Finally all the users can be retrived belongs to the Entra ID tenant. 




          


    