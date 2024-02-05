Hotel Listing API

=================

The Hotel Listing API provides endpoints to retrieve information about countries and hotels.

Table of Contents

-----------------

-   [Prerequisites](#prerequisites)

-   [Getting Started](#getting-started)

-   [API Endpoints](#api-endpoints)

    -   [Country Controller](#country-controller)

    -   [Hotel Controller](#hotel-controller)

-   [Logging](#logging)

-   [Set Jwt Key](#Set-Jwt-Key)



Prerequisites

-------------

Before you begin, ensure you have the following installed:

-   .NET SDK - To run the application.

-   Visual Studio Code or [Visual Studio](https://visualstudio.microsoft.com/) - For development (optional).

Getting Started

---------------

1.  Clone the repository:

    bashCopy code

    `git clone https://github.com/your-username/hotel-listing-api.git`

2.  Navigate to the project folder:

    bashCopy code

    `cd hotel-listing-api`

3.  Run the application:

    bashCopy code

    `dotnet run`

    The API should be accessible at `https://localhost:5001` or `http://localhost:5000`.

API Endpoints

-------------

### Country Controller

#### Get Countries

-   Description: Retrieve a list of all countries.

-   Endpoint: `GET /api/country`

-   Response:

    -   200 OK: Returns a list of countries.

    -   500 Internal Server Error: If an error occurs during the process.

#### Get Country

-   Description: Retrieve detailed information about a specific country.

-   Endpoint: `GET /api/country/{id}`

-   Parameters:

    -   `id` (integer): The ID of the country.

-   Response:

    -   200 OK: Returns detailed information about the specified country.

    -   500 Internal Server Error: If an error occurs during the process.

### Hotel Controller

#### Get Hotels

-   Description: Retrieve a list of all hotels.

-   Endpoint: `GET /api/hotel`

-   Response:

    -   200 OK: Returns a list of hotels.

    -   500 Internal Server Error: If an error occurs during the process.

#### Get Hotel

-   Description: Retrieve detailed information about a specific hotel.

-   Endpoint: `GET /api/hotel/{id}`

-   Parameters:

    -   `id` (integer): The ID of the hotel.

-   Response:

    -   200 OK: Returns detailed information about the specified hotel.

    -   500 Internal Server Error: If an error occurs during the process.

Logging

-------

The application utilizes [Serilog](https://serilog.net/) for logging. Logs are stored in the "logs" folder, and specific logs related to hotel listings are stored in "hotellistingLogs" within the "logs" folder.

Set Jwt Key

-------
1.  Open Command Prompt:

    -   Press `Win + R` to open the Run dialog.
    -   Type `cmd` and press `Enter` to open Command Prompt.
2.  Check Existing Environment Variables (Optional):

    -   You can check existing environment variables using the `echo %VARIABLE_NAME%` command.
3.  Set JWT Key as Environment Variable:

    -   Use the `setx` command to set the JWT key as an environment variable. Replace `YOUR_JWT_KEY` with your actual JWT key.

        bashCopy code

        `setx JWT_KEY "YOUR_JWT_KEY"`

4.  Verify the Environment Variable:

    -   To verify that the variable has been set, you can use the `echo %JWT_KEY%` command.
5.  Restart Any Affected Applications (If Necessary):

    -   Some applications might require a restart to pick up the new environment variable.
6.  Confirm Environment Variable Persistence:

    -   The `setx` command may not affect the current Command Prompt session. Open a new Command Prompt and verify the environment variable using `echo %JWT_KEY%`.
7.  Done:

    -   You have successfully added the JWT key as an environment variable using the `setx` command.

Note:

-   Make sure to replace `YOUR_JWT_KEY` with your actual JWT key.
-   Be cautious while setting environment variables, as they can impact system behavior.
-   Use the appropriate syntax and quotes, especially if your JWT key contains spaces or special characters.