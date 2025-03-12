# CRUD Project with PostgreSQL and PgAdmin

This repository contains a simple CRUD application using PostgreSQL as the database and PgAdmin for management. The structure was created to serve as a base for new projects that need basic operations for creating, reading, updating, and deleting records in a relational database.

## Technologies Used

- **C# .NET Core**: Framework used to build the application.
- **PostgreSQL**: Relational database.
- **Entity Framework Core**: ORM used to interact with the database.
- **PgAdmin**: Web interface for managing PostgreSQL.
- **Docker** (Optional): Used for running PostgreSQL and PgAdmin in a container.

## Features

The project provides a basic implementation of CRUD with the following operations:

- **Create**: Add new records to the database.
- **Read**: Query and list records.
- **Update**: Update existing records.
- **Delete**: Remove records.

The project is configured to connect to a PostgreSQL database, and you can use PgAdmin to manage the database, view tables, and perform other administrative tasks.

This project uses PostgreSQL as the database and it's already configured in the docker-compose file. To run the aplication, just execute **docker-compose up**.
