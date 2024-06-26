    namespace ProjectOneApi.Models;

    //First DTO.  It will not be added to the ProjectOneApiContext
    //will not be refelected as a table in our DB.  We use it to make our
    //update process simpler, and to make our HTTP requests coming in
    //from the frontend end simpler to write

    public class UsernameUpdateDTO

    {
        public string? OldUsername { get; set; } = string.Empty;
        public string? NewUsername { get; set; } = string.Empty;

    }