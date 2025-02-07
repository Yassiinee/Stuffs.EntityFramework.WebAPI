# EntityFrameworkWebAPI

This project is a .NET 9 Web API using Entity Framework Core and PostgreSQL as the database.

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Docker](https://www.docker.com/get-started)

## Getting Started

### Clone the repository

git clone https://github.com/yourusername/EntityFrameworkWebAPI.git cd EntityFrameworkWebAPI


### Set up the database

The project uses PostgreSQL as the database. You can set it up using Docker.

docker-compose up -d


This will start a PostgreSQL container with the following configuration:
- **User**: admin
- **Password**: secret
- **Database**: dotnetHero
- **Port**: 5432

### Update the database

Apply the migrations to set up the database schema.

dotnet ef database update


### Run the application

dotnet run


The application will start and listen on `http://localhost:5000`.

## Project Structure

- `Models/`: Contains the entity models.
- `Persistence/`: Contains the DbContext and configurations.
- `Controllers/`: Contains the API controllers.
- `docker-compose.yml`: Docker configuration for setting up PostgreSQL.

## Configuration

The application configuration is in `appsettings.json`. Update the connection string if necessary.

"ConnectionStrings": { "DefaultConnection": "Host=localhost;Database=dotnetHero;Username=admin;Password=secret" }

## API Endpoints

Document the available API endpoints here.

## Usage Examples

Provide examples of how to use the API, including sample requests and responses.

## Testing

Include instructions on how to run tests and interpret the results.

## Contributing

Outline guidelines for contributing to the project, including how to submit issues and pull requests.

## Known Issues

List any known issues or limitations of the project.

## Troubleshooting

Provide common troubleshooting steps for issues that users might encounter.

## Changelog

Maintain a changelog to document changes, improvements, and bug fixes over time.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

