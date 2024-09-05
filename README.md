# .NET Core 8 JWT Authentication 

## About The Project

This project provides registration and login functionality using JWT tokens for authentication. It includes endpoints for user registration, login, and movie retrieval.

---

## Endpoints

### Authentication

#### 1. Register a User

- **Method:** `POST`
- **URL:** `/auth/register`
- **Request Body:**
    ```json
    {
      "userName": "your_username",
      "firstName": "your_first_name",
      "password": "your_password"
    }
    ```
- **Response:**
  - `204 No Content` - User successfully registered.

---

#### 2. Login a User

- **Method:** `POST`
- **URL:** `/auth/login`
- **Request Body:**
    ```json
    {
      "userName": "your_username",
      "password": "your_password"
    }
    ```
- **Response:**
  - `200 OK` - Returns the JWT token.
    ```json
    {
      "token": "your_jwt_token"
    }
    ```

---

### Movie Management

#### 3. Get Movies

- **Method:** `GET`
- **URL:** `/movie`
- **Authorization:** Bearer token required.
- **Response:**
  - `200 OK` - Returns a list of movies for example.
    ```json
    [
      {
        "name": "Forrest Gump",
        "duration": "02:00:00"
      },
      {
        "name": "Movie 43",
        "duration": "03:00:00"
      }
    ]
    ```

---

