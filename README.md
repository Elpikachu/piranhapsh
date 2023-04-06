# Basic setup of Piranha CMS on Platform.sh

This basic demo builds a Piranha CMS instance on Platform.sh for demo purposes *only*.

We are using .NET Core 6.0, and the base install was done using the `dotnet new -i Piranha.Templates` command.

## Customizations
### Using the PSH port instead of the default one
This was done by updating the appsettings.json file and forcing the URLs to be presented on the port 8888. A better usage would to use the $PORT variable.

### Local database using SQLite
For the demo purposes (and although a PostgreSQL database will be deployed), the data will be stored on a mount based directory, through SQLite. A better usage would be to use the PostgreSQL service, and read the configuration through the $PLATFORM_RELATIONSHIPS variable.

